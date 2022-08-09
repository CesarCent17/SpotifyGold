using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SpotifyGold.Helpers;
using SpotifyGold.MVVM.Model;

namespace SpotifyGold.MVVM.View
{
    /// <summary>
    /// Lógica de interacción para SearchImageView.xaml
    /// </summary>
    public partial class SearchImageView : UserControl
    {
        public SearchImageView()
        {
            Task.Run(async () => await SearchHelper.GetTokenAsync());
            InitializeComponent();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (SearchBox.Text == string.Empty)
            {
                System.Console.WriteLine("La lista es nula");
                ListArtist.ItemsSource = null;
                return;
            }
            var result = SearchHelper.SearchArtistOrSong(SearchBox.Text);

            if (result == null)
            {
                return;
            }
            var listArtist = new List<SpotifyArtist>();

            foreach (var item in result.artists.items)
            {
                listArtist.Add(new SpotifyArtist()
                {
                    ID = item.id,
                    Image = item.images.Any() ? item.images[0].url : "https://w7.pngwing.com/pngs/973/860/png-transparent-anonym-avatar-default-head-person-unknown-user-user-pictures-icon-thumbnail.png",
                    Name = item.name,
                    Popularity = $"{item.popularity}%",
                    Followers = $"{item.followers.total.ToString("N")} seguidores",

                });
            }
            ListArtist.ItemsSource = listArtist;
        }
    }
}
