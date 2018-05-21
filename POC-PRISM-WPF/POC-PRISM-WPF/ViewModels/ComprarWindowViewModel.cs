using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_PRISM_WPF.ViewModels
{
   public  class ComprarWindowViewModel : BindableBase
    {

        public DelegateCommand<string> NavigateToBuy { get; private set; }

        public ComprarWindowViewModel()
        {
            NavigateToBuy = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string obj)
        {
            NavigateToBuy = this.NavigateToBuy;
        }


    }
}
