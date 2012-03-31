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
using CheckOutModule.ViewModels;

namespace CheckOutModule.Views
{
    public partial class CheckOutListView : UserControl, IViewRightRegion
    {
        public CheckOutListView()
        {
            InitializeComponent();
        }

        [Dependency]
        public ICheckOutListViewModel ViewModel
        {
            get { return DataContext as ICheckOutListViewModel; }
            set { DataContext = value; }
        }
    }
}
