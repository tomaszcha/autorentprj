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
using DepartmentModule.ViewModels;
using DepartmentModule.Views;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using ShellInfrastracture;
using EventInfrastracture;


namespace DepartmentModule
{
    public class DepartmentModule : ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.RightPanelName, () => UnityContainer.Resolve<IViewRightRegion>("DepartmentView"));
        }

        protected override void RegisterTypesDependencies()
        {
            UnityContainer.RegisterType<IDepartmentViewModel, DepartmentViewModel>();
            UnityContainer.RegisterType<IViewRightRegion, DepartmentView>("DepartmentView", new ContainerControlledLifetimeManager());
        }
    }
}
