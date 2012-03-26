﻿using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using ModulesInfrastructure;
using Menu.Views;
using ShellInfrastracture;
using ModulesInfrastructure.Views;
using EventInfrastracture;
using Menu.ModelViews;
using Microsoft.Practices.ServiceLocation;

namespace Menu
{
    public class MenuModule : ModuleBase 
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.MenuPanelName, () => UnityContainer.Resolve<IMenuView>());
            EventAggregator.GetEvent<MenuEvent>().Subscribe(onRightRegionNeedChangeEvent);
        }

        protected override void RegisterTypesDependencies()
        {
            UnityContainer.RegisterType<IMenuView, MenuView>();
            UnityContainer.RegisterType<IMenuViewModel, MenuViewModel>();
        }

        public void onRightRegionNeedChangeEvent(string views)
        {
            IRegion region = RegionManager.Regions[RegionNames.RightPanelName];
            region.Activate(UnityContainer.Resolve<IViewRightRegion>(views));
        }
    }
}