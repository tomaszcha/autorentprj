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
using ModulesInfrastructure.Views;
using Microsoft.Practices.Unity;
using CustomerModule.ViewModels;

namespace CustomerModule.Views
{
    public partial class ConditionalOfRentalView : UserControl, IViewRightRegion
    {
        public ConditionalOfRentalView()
        {
            InitializeComponent();
        }
             
        [Dependency]
        public IConditionalOfRentalViewModel ViewModel
        {
            get { return DataContext as IConditionalOfRentalViewModel; }
            set { DataContext = value; }
        }
    }
}
