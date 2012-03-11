using Microsoft.Practices.Prism.Regions;
using ModulesInfrastructure;
using Menu.Views;

namespace Menu
{
    public class MenuModule : ModuleBase 
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion("MenuRegion", typeof(MenuView));
        }

        protected override void RegisterTypesDependencies()
        {
            //UnityContainer.RegisterType<IOrderListViewModel, OrderListViewModel>();
        }
    }
}
