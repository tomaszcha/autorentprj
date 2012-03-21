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
using GlblManagerModule.View;

namespace GlblManagerModule
{
    public class OfficeListModule : ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion("LeftRegion", typeof(OfficeListView));
        }

    }
}
