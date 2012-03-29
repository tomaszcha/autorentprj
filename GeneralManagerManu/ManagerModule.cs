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
using GeneralManagerManu.Views;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using EventInfrastracture;
using ModuleInfrastracture.ViewModels;

namespace GeneralManagerManu
{
    public class ManagerModule : ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.MenuPanelName, () => UnityContainer.Resolve<IViewMenuRegion>("ManagerMenuView"));

           // EventAggregator.GetEvent<MenuEvent>().Subscribe(onRightRegionNeedChangeEvent);
        }

        protected override void RegisterTypesDependencies()
        {
            //UnityContainer.RegisterType<ICustomerViewModel, CustomerViewModel>();
            UnityContainer.RegisterType<IViewMenuRegion, generalManagerView>("ManagerMenuView", new ContainerControlledLifetimeManager());
        }

    }
}
