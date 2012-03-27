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
using ModuleInfrastracture.Views;
using CustomerModule.ViewModels;
using CustomerModule.Views;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using ShellInfrastracture;
using EventInfrastracture;

namespace CustomerModule
{
    public class CustomerModule : ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.RightPanelName, () => UnityContainer.Resolve<IViewRightRegion>("CustomerView"));
        }

        protected override void RegisterTypesDependencies()
        {
            UnityContainer.RegisterType<ICustomerViewModel, CustomerViewModel>();
            UnityContainer.RegisterType<IViewRightRegion, CustomerView>("CustomerView", new ContainerControlledLifetimeManager());
        }
    }
}
