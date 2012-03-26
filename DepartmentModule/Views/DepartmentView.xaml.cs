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
using DepartmentModule.ViewModels;

namespace DepartmentModule.Views
{
    public partial class DepartmentView : UserControl, IViewRightRegion
    {
        public DepartmentView()
        {
            InitializeComponent();
        }

        [Dependency]
        public IDepartmentViewModel ViewModel
        {
            get { return DataContext as IDepartmentViewModel; }
            set { DataContext = value; }
        }   
    }
}
