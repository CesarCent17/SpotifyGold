using Newtonsoft.Json;
using RestSharp;
using SpotifyGold.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static SpotifyGold.MVVM.Model.SpotifySearch;

namespace SpotifyGold.Helpers
{
    public static class SearchHelper
    {
        public static Token token { get; set; }

        //Obtiene el token
        public static async Task GetTokenAsync()
        {
            #region SecretVault
            string clientID = "d6c62bd2908e49a68a29c204b9c716e5";

            string clientSecret = "7af3b3575a264224abfc9f22c380bbfb";
            #endregion

            //Codifica los strings del clientID, clienteSecret y los convierte en una matriz de bytes
            string auth = Convert.ToBase64String(Encoding.UTF8.GetBytes(clientID + ":" + clientSecret));

            //Lista de Llave-Valor que contiene un elemento
            List<KeyValuePair<string, string>> args = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials")
            };

            //Instancia de HttpClient, sesión para enviar solicitudes HTTP. 
            HttpClient client = new HttpClient(); 
            client.DefaultRequestHeaders.Add("Authorization", $"Basic {auth}");

            // Codifica mi lista de tipo KeyValuePair y crea una instancia de FormUrlEncodedContent
            HttpContent content = new FormUrlEncodedContent(args);

            HttpResponseMessage resp = await client.PostAsync("https://accounts.spotify.com/api/token", content); //es como una firma para traerme los objetos
            string msg = await resp.Content.ReadAsStringAsync();

            //Deserializar el msg, pasa a ser un objeto tipo Token
            token = JsonConvert.DeserializeObject<Token>(msg);
        }

        //Metodo que me retorna valores de tipo SpotifyResult
        public static SpotifyResult SearchArtistOrSong(string searchWord)
        {
            
            // instancio client, request, response y ejecuto la solicitud
            var client = new RestClient("https://api.spotify.com/v1/search");
            client.AddDefaultHeader("Authorization", $"Bearer {token.access_token}");
            var request = new RestRequest($"?q={searchWord}&type=artist", Method.Get);
            var response = client.Execute(request);

            //si la solicitud tuvo exito
            if (response.IsSuccessful)
            {
                //el content se deserializa
                var result = JsonConvert.DeserializeObject<SpotifyResult>(response.Content);
                return result;
            }

            // si no, retorna nulo
            else
            {
                return null;
            }

        }
    }
}
