using Prism.Modularity;
using Prism.Regions;
using System;
using Microsoft.Practices.Unity;
using Prism.Unity;
using POC_PRISM_WPF.Views;

namespace ModuleViews
{
    public class ModuleViewsModule : IModule
    {
        private IRegionManager _regionManager;
        private IUnityContainer _container;

        public ModuleViewsModule(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _container.RegisterTypeForNavigation<BuyWindowView>();
            
        }
    }
}