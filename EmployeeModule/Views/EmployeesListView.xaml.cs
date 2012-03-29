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
using EmployeeModule.ViewModels;

namespace EmployeeModule.Views
{
    public partial class EmployeesListView : UserControl, IViewRightRegion
    {
        public EmployeesListView()
        {
            InitializeComponent();
        }

        [Dependency]
        public IEmployeeListViewModel ViewModel
        {
            get { return DataContext as IEmployeeListViewModel; }
            set { DataContext = value; }
        } 
    }
}
