using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using ModuleInfrastracture.Views;
using GeneralManagerManu.ViewModels;
using Microsoft.Practices.Unity;

namespace GeneralManagerManu.Views
{
    public partial class generalManagerView : UserControl, IViewMenuRegion
    {
        public generalManagerView()
        {
            InitializeComponent();
        }

        [Dependency]
        public IManagerViewModel ViewModel
        {
            get { return DataContext as IManagerViewModel; }
            set { DataContext = value; }
        } 
    }
}
