using POC_PRISM_WPF.Views;
using System.Windows;
using Prism.Modularity;
using Autofac;
using Prism.Autofac;
using ModuloListaProdutos;

namespace POC_PRISM_WPF
{
    class Bootstrapper : AutofacBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<NavigationWindowView>();
        }
        
        protected override void ConfigureModuleCatalog()
        {
            var moduleCatalog = (ModuleCatalog)ModuleCatalog;
            moduleCatalog.AddModule(typeof(ModuloListaProdutosModule));
        }
    }
}
