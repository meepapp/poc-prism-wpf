﻿using Prism.Mvvm;

namespace POC_PRISM_WPF.ViewModels
{
    public class NavigationWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public NavigationWindowViewModel()
        {

        }
    }
}
