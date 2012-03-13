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
using OrderEdit.ViewModels;
using Microsoft.Practices.Unity;

namespace OrderEdit.Views
{
    public partial class OrderView : UserControl, IOrderView
    {
        public OrderView()
        {
            InitializeComponent();
            
        }

        #region Implementation of IOrderView

        [Dependency]
        public IOrderViewModel ViewModel
        {
            get { return DataContext as IOrderViewModel; }
            set { DataContext = value; }
        }

        #endregion
    }
}
