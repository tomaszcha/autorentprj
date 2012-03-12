using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using ModulesInfrastructure;
using Menu.Views;
using ShellInfrastracture;
using ModulesInfrastructure.Views;
using EventInfrastracture;
using Menu.ModelViews;
using Microsoft.Practices.ServiceLocation;

namespace Menu
{
    public class MenuModule : ModuleBase 
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion("MenuRegion", () => UnityContainer.Resolve<IMenuView>());
            EventAggregator.GetEvent<MenuEvent>().Subscribe(onRightRegionNeedChangeEvent);
        }

        protected override void RegisterTypesDependencies()
        {
            UnityContainer.RegisterType<IMenuView, MenuView>();
            UnityContainer.RegisterType<IMenuViewModel, MenuViewModel>();
        }

        public void onRightRegionNeedChangeEvent(string views)
        {
            IRegion region = RegionManager.Regions[RegionNames.RightPanelName];
            switch (views)
            {
                case "IHomeView":
                    region.Activate(UnityContainer.Resolve<Home.Views.IHomeView>());
                    break;
            }
        }
    }
}
