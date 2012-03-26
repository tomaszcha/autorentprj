﻿using System;
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


namespace AutoModule.Views
{
    public partial class AutoView : UserControl, IViewRightRegion
    {
        public AutoView()
        {
            InitializeComponent();
        }

        [Dependency]
        public IAutoViewModel ViewModel
        {
            get { return DataContext as IAutoViewModel; }
            set { DataContext = value; }
        }   
    }
}
