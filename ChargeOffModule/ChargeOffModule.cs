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
using ChargeOffModule.ViewModels;
using ChargeOffModule.Views;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using ShellInfrastracture;
using EventInfrastracture;
using ChargeOffModule.Events;
using ModuleInfrastracture.ViewModels;

namespace ChargeOffModule
{
    public class ChargeOffModule : ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.LeftPanelName, () => UnityContainer.Resolve<IViewLeftRegion>("ChargeOffView"));
            RegionManager.RegisterViewWithRegion(RegionNames.RightPanelName, () => UnityContainer.Resolve<IViewRightRegion>("ChargeOffView"));
        }

        protected override void RegisterTypesDependencies()
        {
            UnityContainer.RegisterType<IChargeOffViewModel, ChargeOffViewModel>();
            UnityContainer.RegisterType<IViewLeftRegion, ChargeOffView>("ChargeOffView", new ContainerControlledLifetimeManager());

            UnityContainer.RegisterType<IChargeOffListViewModel, ChargeOffListViewModel>();
            UnityContainer.RegisterType<IViewRightRegion, ChargeOffListView>("ChargeOffView", new ContainerControlledLifetimeManager());

        }

        public void onEmployeeSelect(ViewModelBase viewModel)
        {

        }
    }
}
