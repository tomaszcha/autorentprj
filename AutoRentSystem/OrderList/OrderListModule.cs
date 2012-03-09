using ModulesInfrastructure;
using ShellInfrastracture;
using OrderList.Views;
using OrderList.ViewModels;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace OrderList
{
    public class OrderListModule : ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion("LeftRegion", typeof(OrderListView));
        }

        protected override void RegisterTypesDependencies()
        {
            //UnityContainer.RegisterType<IOrderListViewModel, OrderListViewModel>();
        }
    }
}
