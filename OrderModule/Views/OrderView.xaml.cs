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
    public partial class OrderView : UserControl, IViewLeftRegion
    {
        public OrderView()
        {
            InitializeComponent();
        }

        [Dependency]
        public IOrderViewModel ViewModel
        {
            get { return DataContext as IOrderViewModel; }
            set { DataContext = value; }
        } 
    }
}
