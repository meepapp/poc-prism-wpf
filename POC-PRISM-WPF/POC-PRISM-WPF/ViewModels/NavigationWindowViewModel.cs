<<<<<<< HEAD
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
=======
﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace POC_PRISM_WPF.ViewModels
{
    public class NavigationWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand<string> NavigateCommand { get; private set; }

        public NavigationWindowViewModel(IRegionManager regionManager)
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
>>>>>>> cd57c6e8a40179ec46a289dd62b1be7f374fd8d6