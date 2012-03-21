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
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace GlblManagerModule
{
    /// <summary>
    /// presents a list of offices
    /// </summary>
    public class OfficeDataModule : ModuleBase
    {
        protected override void RegisterViewsInRegions()
        {
            RegionManager.RegisterViewWithRegion("LeftRegion", typeof(OfficeListView));
        }

        protected override void RegisterTypesDependencies()
        {
            //throw new NotImplementedException();
        }
    }
}
