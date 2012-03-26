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
using DamageClassModule.ViewModels;

namespace DamageClassModule.Views
{
    public partial class DamageClassView : UserControl, IViewRightRegion
    {
        public DamageClassView()
        {
            InitializeComponent();
        }

        [Dependency]
        public IDamageClassViewModel ViewModel
        {
            get { return DataContext as IDamageClassViewModel; }
            set { DataContext = value; }
        }   
    }
}
