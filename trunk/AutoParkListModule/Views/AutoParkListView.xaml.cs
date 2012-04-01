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
using Microsoft.Practices.Unity;
using AutoParkListModule.ViewModels;

namespace AutoParkListModule.Views
{
    public partial class AutoParkListView : UserControl, IViewRightRegion
    {
        public AutoParkListView()
        {
            InitializeComponent();
        }

        [Dependency]
        public IAutoParkListViewModel ViewModel
        {
            get { return DataContext as IAutoParkListViewModel; }
            set { DataContext = value; }
        }
    }
}
