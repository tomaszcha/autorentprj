using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using OrderList.ViewModels;
using Microsoft.Practices.Unity;

namespace OrderList.Views
{
    public partial class OrderListView : UserControl, IOrderListView
    {
        public OrderListView()
        {
            InitializeComponent();
        }

        #region Implementation of IOrderListView

        //[Dependency]
        public IOrderListViewModel ViewModel
        {
            get { return DataContext as IOrderListViewModel; }
            set { DataContext = value; }
        }

        #endregion
    }
}
