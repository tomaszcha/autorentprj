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


namespace AutoPark
{
    public class AutoParkModule: ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion("RightRegion", () => UnityContainer.Resolve<IAutoParkView>());
        }

        protected override void RegisterTypesDependencies()
        {
            UnityContainer.RegisterType<IAutoParkView, AutoParkView>(new ContainerControlledLifetimeManager());
        }
    }
}
