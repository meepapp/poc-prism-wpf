﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace POC_PRISM_WPF.ViewModels
{
    public class BuyWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand<string> NavigateCommand { get; private set; }

        public BuyWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string navigatePath)
        {
            if(navigatePath != null)
                _regionManager.RequestNavigate("", navigatePath);
        }
    }
}