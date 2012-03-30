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
using ApplicationModule.ViewModels;
using ApplicationModule.Views;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using ShellInfrastracture;
using EventInfrastracture;
using ApplicationModule.Events;
using ModuleInfrastracture.ViewModels;

namespace ApplicationModule
{
    public class ApplicationModule : ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.LeftPanelName, () => UnityContainer.Resolve<IViewLeftRegion>("ApplicationView"));
            RegionManager.RegisterViewWithRegion(RegionNames.RightPanelName, () => UnityContainer.Resolve<IViewRightRegion>("ApplicationView"));
        }

        protected override void RegisterTypesDependencies()
        {
            UnityContainer.RegisterType<IApplicationViewModel, ApplicationViewModel>();
            UnityContainer.RegisterType<IViewLeftRegion, ApplicationView>("ApplicationView", new ContainerControlledLifetimeManager());

            UnityContainer.RegisterType<IApplicationsListViewModel, ApplicationsListViewModel>();
            UnityContainer.RegisterType<IViewRightRegion, ApplicationsListView>("ApplicationView", new ContainerControlledLifetimeManager());

        }

        public void onAutoSelect(ViewModelBase viewModel)
        {

        }
    }
}
