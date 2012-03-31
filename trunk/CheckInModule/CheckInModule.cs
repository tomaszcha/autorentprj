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
using CheckInModule.ViewModels;
using CheckInModule.Views;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using ShellInfrastracture;
using EventInfrastracture;
using CheckInModule.Events;
using ModuleInfrastracture.ViewModels;

namespace CheckInModule
{
    public class CheckInModule : ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.LeftPanelName, () => UnityContainer.Resolve<IViewLeftRegion>("CheckInView"));
            RegionManager.RegisterViewWithRegion(RegionNames.RightPanelName, () => UnityContainer.Resolve<IViewRightRegion>("CheckInView"));
        }

        protected override void RegisterTypesDependencies()
        {
            UnityContainer.RegisterType<ICheckInViewModel, CheckInViewModel>();
            UnityContainer.RegisterType<IViewLeftRegion, CheckInView>("CheckInView", new ContainerControlledLifetimeManager());

            UnityContainer.RegisterType<ICheckInListViewModel, CheckInListViewModel>();
            UnityContainer.RegisterType<IViewRightRegion, CheckInListView>("CheckInView", new ContainerControlledLifetimeManager());

        }

        public void onEmployeeSelect(ViewModelBase viewModel)
        {

        }
    }
}
