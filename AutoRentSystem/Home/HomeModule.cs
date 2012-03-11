using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using ModulesInfrastructure;
using Home.Views;

namespace Home
{
    public class HomeModule : ModuleBase          
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion("RightRegion", () => UnityContainer.Resolve<IHomeView>());
        }

        protected override void RegisterTypesDependencies()
        {
            UnityContainer.RegisterType<IHomeView, HomeView>(new ContainerControlledLifetimeManager());
        }
    }
}
