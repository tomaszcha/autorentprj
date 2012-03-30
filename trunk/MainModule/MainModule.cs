using ModuleInfrastracture;
using ShellInfrastracture;
using ModuleInfrastracture.Views;
using MainModule.Views;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using EventInfrastracture;
using System.Linq;
using MainModule.ViewModels;

namespace MainModule
{
    public class MainModule : ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.MenuPanelName, () => UnityContainer.Resolve<IViewMenuRegion>(ViewNames.ViewName));
            RegionManager.RegisterViewWithRegion(RegionNames.RightPanelName, () => UnityContainer.Resolve<IViewRightRegion>(ViewNames.ViewName));
            
            DeactivateMenu();

            EventAggregator.GetEvent<MenuEvent>().Subscribe(onRegionNeedChangeEvent);
        }

        protected override void RegisterTypesDependencies()
        {
            UnityContainer.RegisterType<IMainViewModel, MainViewModel>();
            UnityContainer.RegisterType<IViewMenuRegion, CustomerMenuView>(ViewNames.ViewName, new ContainerControlledLifetimeManager());
            UnityContainer.RegisterType<IViewRightRegion, MainPageView>(ViewNames.ViewName, new ContainerControlledLifetimeManager());

        }

        private void DeactivateMenu()
        {
            IRegion region = RegionManager.Regions[RegionNames.MenuPanelName];
            region.Deactivate(UnityContainer.Resolve<IViewMenuRegion>(ViewNames.ViewName));
        }

        public void onRegionNeedChangeEvent(string views)
        {        
            IRegion region = RegionManager.Regions[RegionNames.MenuPanelName];
            region.Activate(UnityContainer.Resolve<IViewMenuRegion>(ViewNames.ViewName));

            region = RegionManager.Regions[RegionNames.RightPanelName];
            region.Deactivate(region.ActiveViews.FirstOrDefault());
            //region.Activate(UnityContainer.Resolve<IViewRightRegion>(views));
        }
    }
}
