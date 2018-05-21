using Prism.Mvvm;
using Prism.Regions;

namespace ModuloListaProdutos.ViewModels
{
    public class VendaWindowViewModel : BindableBase, INavigationAware
    {
        //IRegionManager _regionManager;
        //private IRegionNavigationJournal _journal;

        private string _title = "VendaWindow";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        //private string _message;
        //public string Message
        //{
        //    get { return _message; }
        //    set { SetProperty(ref _message, value); }
        //}
        //public DelegateCommand GoForwardCommand { get; set; }
        //private int _pageViews;
        //public int PageViews
        //{
        //    get { return _pageViews; }
        //    set { SetProperty(ref _pageViews, value); }
        //}

        public VendaWindowViewModel(RegionManager regionManager)
        {
            //Message = "View A from your Prism Module";

            //_regionManager = regionManager;
            //GoForwardCommand = new DelegateCommand(GoForward, CanGoForward);
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            //GoForwardCommand.CanExecute();
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return 3 != 1;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }
        //private void GoForward()
        //{
        //    _journal.GoForward();
        //}

        //private bool CanGoForward()
        //{
        //    return _journal != null && _journal.CanGoForward;
        //}
    }
}
