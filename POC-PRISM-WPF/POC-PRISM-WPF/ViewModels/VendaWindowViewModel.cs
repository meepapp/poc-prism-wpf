using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Regions;

namespace POC_PRISM_WPF.ViewModels
{
	public class VendaWindowViewModel : BindableBase, INavigationAware
	{
	    private string _title = "VendaWindowView";
	    public string Title
	    {
	        get { return _title; }
	        set { SetProperty(ref _title, value); }
	    }
        public VendaWindowViewModel()
        {

        }
	    public void OnNavigatedTo(NavigationContext navigationContext)
	    {

	    }

	    public bool IsNavigationTarget(NavigationContext navigationContext)
	    {
	        return false;
	    }

	    public void OnNavigatedFrom(NavigationContext navigationContext)
	    {

	    }
    }
}
