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
            ApiConsumption.actionApi(SearchBox, ListArtist);
        }
    }
}
