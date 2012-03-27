using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using ModuleInfrastracture;
using ShellInfrastracture;
using ModuleInfrastracture.Views;
using EventInfrastracture;
using Microsoft.Practices.Prism.Regions;
using CustomerMenuModule.Views;
using Microsoft.Practices.Unity;

namespace CustomerMenuModule
{
    public class CustomerMenuModule : ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.MenuPanelName, () => UnityContainer.Resolve<IViewMenuRegion>("CustomerMenuView"));
        }

        protected override void RegisterTypesDependencies()
        {
            UnityContainer.RegisterType<IViewMenuRegion, CustomerMenuView>("CustomerMenuView", new ContainerControlledLifetimeManager());
            EventAggregator.GetEvent<MenuEvent>().Subscribe(onRightRegionNeedChangeEvent);
        }

        public void onRightRegionNeedChangeEvent(string views)
        {
            IRegion region = RegionManager.Regions[RegionNames.RightPanelName];
            region.Activate(UnityContainer.Resolve<IViewRightRegion>(views));
        }
    }
}
