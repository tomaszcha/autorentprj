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
using CustomerModule.ViewModels;
using CustomerModule.Views;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using ShellInfrastracture;
using EventInfrastracture;
using CustomerModule.Events;
using ModuleInfrastracture.ViewModels;

namespace CustomerModule
{
    public class CustomerModule : ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.LeftPanelName, () => UnityContainer.Resolve<IViewLeftRegion>("CustomerView"));
            RegionManager.RegisterViewWithRegion(RegionNames.RightPanelName, () => UnityContainer.Resolve<IViewRightRegion>("CustomersListView"));
        }

        protected override void RegisterTypesDependencies()
        {
            UnityContainer.RegisterType<ICustomerViewModel, CustomerViewModel>();
            UnityContainer.RegisterType<IViewLeftRegion, CustomerView>("CustomerView", new ContainerControlledLifetimeManager());

            UnityContainer.RegisterType<ICustomersListViewModel, CustomersListViewModel>();
            UnityContainer.RegisterType<IViewRightRegion, CustomersListView>("CustomersListView", new ContainerControlledLifetimeManager());
        
        }

        public void onEmployeeSelect(ViewModelBase viewModel)
        {
             
        }
    }
}
