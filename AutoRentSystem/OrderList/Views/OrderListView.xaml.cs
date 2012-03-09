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
using OrderList.ViewModels;

namespace OrderList.Views
{
    public partial class OrderListView : UserControl, IOrderListView
    {
        public OrderListView()
        {
            InitializeComponent();
        }

        #region Implementation of IOrderListView

        [Dependency]
        public IOrderListViewModel ViewModel
        {
            get { return DataContext as IOrderListViewModel; }
            set { DataContext = value; }
        }

        #endregion
    }
}
