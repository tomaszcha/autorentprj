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
using OrderModule.ViewModels;
using OrderModule.Views;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using ShellInfrastracture;
using EventInfrastracture;
using OrderModule.Events;
using ModuleInfrastracture.ViewModels;


namespace OrderModule
{
    public class OrderModule : ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.LeftPanelName, () => UnityContainer.Resolve<IViewLeftRegion>("OrderView"));
            RegionManager.RegisterViewWithRegion(RegionNames.RightPanelName, () => UnityContainer.Resolve<IViewRightRegion>("OrderView"));
        }

        protected override void RegisterTypesDependencies()
        {
            UnityContainer.RegisterType<IOrderViewModel, OrderViewModel>();
            UnityContainer.RegisterType<IViewLeftRegion, OrderView>("OrderView", new ContainerControlledLifetimeManager());

            UnityContainer.RegisterType<IOrdersListViewModel, OrdersListViewModel>();
            UnityContainer.RegisterType<IViewRightRegion, OrdersListView>("OrderView", new ContainerControlledLifetimeManager());

        }

        public void onOrderSelect(ViewModelBase viewModel)
        {

        }
    }
}
