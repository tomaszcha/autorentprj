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
using CheckInModule.ViewModels;

namespace CheckInModule.Views
{
    public partial class CheckInListView : UserControl, IViewRightRegion
    {
        public CheckInListView()
        {
            InitializeComponent();
        }

        [Dependency]
        public ICheckInListViewModel ViewModel
        {
            get { return DataContext as ICheckInListViewModel; }
            set { DataContext = value; }
        }
    }
}
