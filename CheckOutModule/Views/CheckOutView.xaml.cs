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
using System.Windows.Shapes;
using Microsoft.Practices.Unity;
using CheckOutModule.ViewModels;


namespace CheckOutModule.Views
{
    public partial class CheckOutView : UserControl, IViewLeftRegion
    {
        public CheckOutView()
        {
            InitializeComponent();
        }

        [Dependency]
        public ICheckOutViewModel ViewModel
        {
            get { return DataContext as ICheckOutViewModel; }
            set { DataContext = value; }
        }  
    }
}
