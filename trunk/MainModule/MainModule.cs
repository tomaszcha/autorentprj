using ModuleInfrastracture;
using ShellInfrastracture;
using ModuleInfrastracture.Views;
using MainModule.Views;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using EventInfrastracture;
using System.Linq;
using MainModule.ViewModels;
using MainModule.Events;

namespace MainModule
{
    public class MainModule : ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.MenuPanelName, () => UnityContainer.Resolve<IViewMenuRegion>(MenuNames.Customer));
            RegionManager.RegisterViewWithRegion(RegionNames.RightPanelName, () => UnityContainer.Resolve<IViewRightRegion>(ViewNames.ViewName));
            
            DeactivateMenu();

            EventAggregator.GetEvent<ActivateCustomerView>().Subscribe(onActivateCustomerEvent);
            EventAggregator.GetEvent<ActivateManagerViews>().Subscribe(onActivateManagerEvent);

        }

        protected override void RegisterTypesDependencies()
        {
            UnityContainer.RegisterType<IMainViewModel, MainViewModel>();
            UnityContainer.RegisterType<IViewMenuRegion, CustomerMenuView>(MenuNames.Customer, new ContainerControlledLifetimeManager());
            UnityContainer.RegisterType<IViewRightRegion, MainPageView>(ViewNames.ViewName, new ContainerControlledLifetimeManager());

        }

        private void DeactivateMenu()
        {
            IRegion region = RegionManager.Regions[RegionNames.MenuPanelName];
            region.Deactivate(UnityContainer.Resolve<IViewMenuRegion>(MenuNames.Customer));
        }

        public void onActivateCustomerEvent(string views)
        {        
            IRegion region = RegionManager.Regions[RegionNames.RightPanelName];
            //region.Activate(UnityContainer.Resolve<IViewRightRegion>(views));

            region = RegionManager.Regions[RegionNames.MenuPanelName];
            region.Activate(UnityContainer.Resolve<IViewMenuRegion>(MenuNames.Customer));
            
        }
        public void onActivateManagerEvent(string views)
        {
            IRegion region = RegionManager.Regions[RegionNames.RightPanelName];
            region.Activate(UnityContainer.Resolve<IViewMenuRegion>(views));

            //region = RegionManager.Regions[RegionNames.MenuPanelName];
            //region.Activate(UnityContainer.Resolve<IViewMenuRegion>(MenuNames.Manager));
        }
    }
}
