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
using ApplicationModule.ViewModels;

namespace ApplicationModule.Views
{
    public partial class ApplicationsListView : UserControl, IViewRightRegion
    {
        public ApplicationsListView()
        {
            InitializeComponent();
        }

        [Dependency]
        public IApplicationsListViewModel ViewModel
        {
            get { return DataContext as IApplicationsListViewModel; }
            set { DataContext = value; }
        }
    }
}
