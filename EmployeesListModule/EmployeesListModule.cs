using ModuleInfrastracture.Views;
using Microsoft.Practices.Prism.Regions;
using ShellInfrastracture;
using Microsoft.Practices.Unity;
using EmployeesListModule.Views;
using ModuleInfrastracture;

namespace EmployeesListModule
{
    public class EmployeesListModule : ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.LeftPanelName, () => UnityContainer.Resolve<IViewLeftRegion>("EmployeesListView"));
        }

        protected override void RegisterTypesDependencies()
        {
            //UnityContainer.RegisterType<I, CustomerViewModel>();
            UnityContainer.RegisterType<IViewLeftRegion, EmployeesListView>("EmployeesListView", new ContainerControlledLifetimeManager());
        }
    }
}
