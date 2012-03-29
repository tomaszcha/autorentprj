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
using CustomerModule.ViewModels;

namespace CustomerModule.Views
{
    public partial class CustomersListView : UserControl, IViewRightRegion
    {
        public CustomersListView()
        {
            InitializeComponent();
        }

        [Dependency]
        public ICustomersListViewModel ViewModel
        {
            get { return DataContext as ICustomersListViewModel; }
            set { DataContext = value; }
        }
    }
}
