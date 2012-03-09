using ModulesInfrastructure;
using Microsoft.Practices.Prism.Regions;
using ApplicationCreate.Views;

namespace ApplicationCreate
{
    public class ApplicationCreateModule : ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion("LeftRegion", typeof(ApplicationCreateView));
        }

        protected override void RegisterTypesDependencies()
        {
            //UnityContainer.RegisterType<IOrderListViewModel, OrderListViewModel>();
        }
    }
}
