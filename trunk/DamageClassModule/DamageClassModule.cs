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
using DamageClassModule.ViewModels;
using DamageClassModule.Views;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using ShellInfrastracture;
using EventInfrastracture;

namespace DamageClassModule
{
    public class DamageClassModule : ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.RightPanelName, () => UnityContainer.Resolve<IViewRightRegion>("DamageClassView"));
        }

        protected override void RegisterTypesDependencies()
        {
            UnityContainer.RegisterType<IDamageClassViewModel, DamageClassViewModel>();
            UnityContainer.RegisterType<IViewRightRegion, DamageClassView>("DamageClassView", new ContainerControlledLifetimeManager());
        }
    }
}
