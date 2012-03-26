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
using ModuleInfrastracture.Views;
using System.Windows.Shapes;
using Microsoft.Practices.Unity;
using CustomerModule.ViewModels;


namespace CustomerModule.Views
{
    public partial class CustomerView : UserControl, IViewRightRegion
    {
        public CustomerView()
        {
            InitializeComponent();
        }

        [Dependency]
        public ICustomerViewModel ViewModel
        {
            get { return DataContext as ICustomerViewModel; }
            set { DataContext = value; }
        }   
    }
}
