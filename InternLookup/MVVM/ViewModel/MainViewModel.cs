using InternLookup.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLookup.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand LogoHomeCommand { get; set; }
        public RelayCommand FeaturedCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public LogoHomeViewModel LogoHomeVM { get; set; }
        public FeaturedViewModel FeaturedVM { get; set; }

        private object varCurentView;

        public object CurrentView
        {
            get { return varCurentView; }
            set
            {
                varCurentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            LogoHomeVM = new LogoHomeViewModel();
            FeaturedVM = new FeaturedViewModel();

            CurrentView = LogoHomeVM;

            HomeViewCommand = new RelayCommand(o => { CurrentView = HomeVM; });
            LogoHomeCommand = new RelayCommand(o => { CurrentView = LogoHomeVM; });
            FeaturedCommand = new RelayCommand(o => { CurrentView = FeaturedVM; });
        }
    }
}
