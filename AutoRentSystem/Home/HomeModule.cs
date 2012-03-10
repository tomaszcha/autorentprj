using Microsoft.Practices.Prism.Regions;
using ModulesInfrastructure;
using Home.Views;

namespace Home
{
    public class HomeModule : ModuleBase          
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion("RightRegion", typeof(HomeView));
        }

        protected override void RegisterTypesDependencies()
        {
            //UnityContainer.RegisterType<IOrderListViewModel, OrderListViewModel>();
        }
    }
}
