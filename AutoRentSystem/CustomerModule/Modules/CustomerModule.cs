﻿using ModulesInfrastructure;
using Microsoft.Practices.Prism.Regions;
using CustomerModule.Views;
using ShellInfrastracture;
using ModulesInfrastructure.Views;
using Microsoft.Practices.Unity;
using CustomerModule.ViewModels;
using CustomerModule.ModelViews;
using EventInfrastracture;

namespace CustomerModule
{
    public class CustomerModule : ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.LeftPanelName, () => UnityContainer.Resolve<IViewLeftRegion>("ApplicationCreate"));

            RegionManager.RegisterViewWithRegion(RegionNames.RightPanelName, () => UnityContainer.Resolve<IViewRightRegion>("HomeView"));
            RegionManager.RegisterViewWithRegion(RegionNames.RightPanelName, () => UnityContainer.Resolve<IViewRightRegion>("AutoParkView"));

            RegionManager.RegisterViewWithRegion(RegionNames.MenuPanelName, () => UnityContainer.Resolve<IViewMenuRegion>());
            EventAggregator.GetEvent<MenuEvent>().Subscribe(onRightRegionNeedChangeEvent);
        }

        protected override void RegisterTypesDependencies()
        {
            UnityContainer.RegisterType<IApplicationCreateViewModel, ApplicationCreateViewModel>();
            UnityContainer.RegisterType<IViewLeftRegion, ApplicationCreateView>("ApplicationCreate", new TransientLifetimeManager());

            UnityContainer.RegisterType<IViewRightRegion, HomeView>("HomeView", new ContainerControlledLifetimeManager());


            UnityContainer.RegisterType<IAutoParkViewModel, AutoParkViewModel>();
            UnityContainer.RegisterType<IViewRightRegion, AutoParkView>("AutoParkView", new ContainerControlledLifetimeManager());


            UnityContainer.RegisterType<IViewMenuRegion, MenuView>();
            UnityContainer.RegisterType<IMenuViewModel, MenuViewModel>();

        }

        public void onRightRegionNeedChangeEvent(string views)
        {
            IRegion region = RegionManager.Regions[RegionNames.RightPanelName];
            region.Activate(UnityContainer.Resolve<IViewRightRegion>(views));
        }
    }
}
