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
using OrderModule.ViewModels;


namespace OrderModule.Views
{
    public partial class OrdersListView : UserControl, IViewRightRegion
    {
        public OrdersListView()
        {
            InitializeComponent();
        }

        [Dependency]
        public IOrdersListViewModel ViewModel
        {
            get { return DataContext as IOrdersListViewModel; }
            set { DataContext = value; }
        } 
    }
}
