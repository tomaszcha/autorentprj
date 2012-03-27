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
using EmployeeModule.ViewModels;
using EmployeeModule.Views;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using ShellInfrastracture;
using EventInfrastracture;

namespace EmployeeModule
{
    public class EmployeeModule : ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.RightPanelName, () => UnityContainer.Resolve<IViewRightRegion>("EmployeeView"));
        }

        protected override void RegisterTypesDependencies()
        {
            UnityContainer.RegisterType<IEmployeeViewModel, EmployeeViewModel>();
            UnityContainer.RegisterType<IViewRightRegion, EmployeeView>("EmployeeView", new ContainerControlledLifetimeManager());
        }

    }
}
