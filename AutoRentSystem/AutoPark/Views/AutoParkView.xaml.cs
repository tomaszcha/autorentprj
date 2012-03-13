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
using AutoPark.ViewModels;
using Microsoft.Practices.Unity;

namespace AutoPark.Views
{
    public partial class AutoParkView : UserControl, IAutoParkView
    {
        public AutoParkView()
        {
            InitializeComponent();
        }
        
        #region Implementation of IAutoParkView

        [Dependency]
        public IAutoParkViewModel ViewModel
        {
            get { return DataContext as IAutoParkViewModel; }
            set { DataContext = value; }
        }

        #endregion
    }
}
