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
using ModulesInfrastructure;
using GlblManagerMenuModule.View;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace GlblManagerMenuModule
{
    public class GlblManagerMenuModule : ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion("MenuRegion", typeof(GlblManagerMenuView));
        }

        protected override void RegisterTypesDependencies()
        {
            //throw new NotImplementedException();
        }
    }
}
