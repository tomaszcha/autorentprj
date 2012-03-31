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
using ChargeOffModule.ViewModels;

namespace ChargeOffModule.Views
{
    public partial class ChargeOffView : UserControl, IViewLeftRegion
    {
        public ChargeOffView()
        {
            InitializeComponent();
        }

        [Dependency]
        public IChargeOffViewModel ViewModel
        {
            get { return DataContext as IChargeOffViewModel; }
            set { DataContext = value; }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }   
    }
}
