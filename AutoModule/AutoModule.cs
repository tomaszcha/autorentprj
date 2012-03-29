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
using AutoModule.Events;
using ModuleInfrastracture.ViewModels;


namespace AutoModule
{
    public class AutoModule : ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.LeftPanelName, () => UnityContainer.Resolve<IViewLeftRegion>("AutoView"));
            RegionManager.RegisterViewWithRegion(RegionNames.RightPanelName, () => UnityContainer.Resolve<IViewRightRegion>("AutoView"));
        }

        protected override void RegisterTypesDependencies()
        {
            UnityContainer.RegisterType<IAutoViewModel, AutoViewModel>();
            UnityContainer.RegisterType<IViewLeftRegion, AutoView>("AutoView", new ContainerControlledLifetimeManager());

            UnityContainer.RegisterType<IAutosListViewModel, AutosListViewModel>();
            UnityContainer.RegisterType<IViewRightRegion, AutosListView>("AutoView", new ContainerControlledLifetimeManager());

        }

        public void onEmployeeSelect(ViewModelBase viewModel)
        {

        }
    }
}
