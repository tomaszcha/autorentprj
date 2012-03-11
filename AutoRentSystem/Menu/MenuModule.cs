using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using ModulesInfrastructure;
using Menu.Views;
using ShellInfrastracture;
using ModulesInfrastructure.Views;
using EventInfrastracture;
using Menu.ModelViews;

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

        private void onRightRegionNeedChangeEvent(string n)
        {
            //if (name != null)
            {
                IRegion region = RegionManager.Regions[RegionNames.RightPanelName];
                region.Activate(UnityContainer.Resolve<Home.Views.HomeView>());
            }
        }
    }
}
