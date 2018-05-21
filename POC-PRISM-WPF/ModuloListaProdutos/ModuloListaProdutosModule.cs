using ModuloListaProdutos.Views;
using Prism.Modularity;
using Prism.Regions;
using Autofac;
using Prism.Autofac;

namespace ModuloListaProdutos
{
    public class ModuloListaProdutosModule : IModule
    {
        IRegionManager _regionManager;
        ContainerBuilder _builder;

        public ModuloListaProdutosModule(ContainerBuilder builder, IRegionManager regionManager)
        {
            _builder = builder;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            //_builder.RegisterTypeForNavigation<VendaWindow>();
            _builder.RegisterType<VendaWindow>().Named<object>("MinhaVendaWidnow");

            //_regionManager.RequestNavigate("ContentRegion", "VendaWindow");
        }
    }
}