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
using AutoPark.Views;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using ModulesInfrastructure;
using ModulesInfrastructure.Views;
using ShellInfrastracture;
using AutoPark.ViewModels;


namespace AutoPark
{
    public class AutoParkModule: ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.RightPanelName, () => UnityContainer.Resolve<IViewRightRegion>("AutoParkView"));
        }

        protected override void RegisterTypesDependencies()
        {
            UnityContainer.RegisterType<IAutoParkViewModel, AutoParkViewModel>();
            UnityContainer.RegisterType<IViewRightRegion, AutoParkView>("AutoParkView", new ContainerControlledLifetimeManager());
        }
    }
}
