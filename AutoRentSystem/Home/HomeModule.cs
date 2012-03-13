using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using ModulesInfrastructure;
using Home.Views;
using ModulesInfrastructure.Views;

namespace Home
{
    public class HomeModule : ModuleBase          
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion("RightRegion", () => UnityContainer.Resolve<IViewRightRegion>("HomeView"));
        }

        protected override void RegisterTypesDependencies()
        {
            UnityContainer.RegisterType<IViewRightRegion, HomeView>("HomeView", new ContainerControlledLifetimeManager());
        }
    }
}
