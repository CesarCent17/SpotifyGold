using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyGold.Core;

namespace SpotifyGold.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand SearchArtistViewCommand { get; set; }
        public RelayCommand SearchImageViewCommand { get; set; }
        public RelayCommand SearchDetailsViewCommand { get; set; }
        public RelayCommand LeaveViewCommand { get; set; }




        public HomeViewModel HomeVM { get; set; }
        public SearchArtistViewModel SearchArtistMV { get; set; }
        public SearchImageViewModel SearchImageMV { get; set; }
        public SearchDetailsViewModel SearchDetailsMV { get; set; }
        public LeaveViewModel LeaveMV { get; set; }




        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            SearchArtistMV = new SearchArtistViewModel();
            SearchImageMV = new SearchImageViewModel();
            SearchDetailsMV = new SearchDetailsViewModel();
            LeaveMV = new LeaveViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            SearchArtistViewCommand = new RelayCommand(o =>
            {
                CurrentView = SearchArtistMV;
            });

            SearchImageViewCommand = new RelayCommand(o =>
            {
                CurrentView = SearchImageMV;
            });

            SearchDetailsViewCommand = new RelayCommand(o =>
            {
                CurrentView = SearchDetailsMV;
            });

            LeaveViewCommand = new RelayCommand(o =>
            {
                CurrentView = LeaveMV;
            });
        }
    }
}
