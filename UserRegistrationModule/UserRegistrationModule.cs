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
using UserRegistrationModule.ViewModels;
using UserRegistrationModule.Views;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using ShellInfrastracture;
using EventInfrastracture;


namespace UserRegistrationModule
{
    public class UserRegistrationModule : ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.RightPanelName, () => UnityContainer.Resolve<IViewRightRegion>("UserRegistrationView"));
        }

        protected override void RegisterTypesDependencies()
        {
            UnityContainer.RegisterType<IUserRegistrationViewModel, UserRegistrationViewModel>();
            UnityContainer.RegisterType<IViewRightRegion, UserRegistrationView>("UserRegistrationView", new ContainerControlledLifetimeManager());
        }
    }
}
