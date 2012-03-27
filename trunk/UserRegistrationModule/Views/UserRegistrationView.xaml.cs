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
using UserRegistrationModule.ViewModels;

namespace UserRegistrationModule.Views
{
    public partial class UserRegistrationView : UserControl, IViewRightRegion
    {
        public UserRegistrationView()
        {
            InitializeComponent();
        }

        [Dependency]
        public IUserRegistrationViewModel ViewModel
        {
            get { return DataContext as IUserRegistrationViewModel; }
            set { DataContext = value; }
        } 
    }
}
