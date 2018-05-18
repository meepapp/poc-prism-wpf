using ModuloListaProdutos.Views;
using Prism.Modularity;
using Prism.Regions;
using System;
using Autofac;
using Prism.Autofac;

namespace ModuloListaProdutos
{
    public class ModuloListaProdutosModule : IModule
    {
        private IRegionManager _regionManager;
        private ContainerBuilder _builder;

        public ModuloListaProdutosModule(ContainerBuilder builder, IRegionManager regionManager)
        {
            _builder = builder;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _builder.RegisterTypeForNavigation<ViewA>();
        }
    }
}