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
using ChargeOffModule.ViewModels;

namespace ChargeOffModule.Views
{
    public partial class ChargeOffListView : UserControl, IViewRightRegion
    {
        public ChargeOffListView()
        {
            InitializeComponent();
        }

        [Dependency]
        public IChargeOffListViewModel ViewModel
        {
            get { return DataContext as IChargeOffListViewModel; }
            set { DataContext = value; }
        }
    }
}
