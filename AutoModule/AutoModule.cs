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
using AutoModule.ViewModels;
using AutoModule.Views;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using ShellInfrastracture;
using EventInfrastracture;


namespace AutoModule
{
    public class AutoModule : ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.RightPanelName, () => UnityContainer.Resolve<IViewRightRegion>("AutoView"));
        }

        protected override void RegisterTypesDependencies()
        {
            UnityContainer.RegisterType<IAutoViewModel, AutoViewModel>();
            UnityContainer.RegisterType<IViewRightRegion, AutoView>("AutoView", new ContainerControlledLifetimeManager());
        }
    }
}
