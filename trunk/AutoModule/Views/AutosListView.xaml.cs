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
using AutoModule.ViewModels;

namespace AutoModule.Views
{
    public partial class AutosListView : UserControl, IViewRightRegion
    {
        public AutosListView()
        {
            InitializeComponent();
        }
   
        [Dependency]
        public IAutosListViewModel ViewModel
        {
            get { return DataContext as IAutosListViewModel; }
            set { DataContext = value; }
        }
    }
}
