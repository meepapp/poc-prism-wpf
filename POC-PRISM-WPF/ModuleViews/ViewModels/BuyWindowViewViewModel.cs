using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace POC_PRISM_WPF.ViewModels
{
    public class BuyWindowViewViewModel : BindableBase, INavigationAware
    {
        private readonly IRegionManager _regionManager;
        private string _title = "BuyWindowView";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        private int _pageViews;
        public int PageViews
        {
            get { return _pageViews; }
            set { SetProperty(ref _pageViews, value); }
        }
        public DelegateCommand<string> NavigateCommand { get; private set; }

        public BuyWindowViewViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string navigatePath)

        {
            if (navigatePath != null)
                _regionManager.RequestNavigate("ContentRegion", navigatePath);
        }


        public BuyWindowViewViewModel()
        {

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            PageViews++;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return PageViews / 3 != 1;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }
    }
}
