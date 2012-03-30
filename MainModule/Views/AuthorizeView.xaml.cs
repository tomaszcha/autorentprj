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
using MainModule.ViewModels;

namespace MainModule.Views
{
    public partial class AuthorizeView : ChildWindow
    {
        public AuthorizeView()
        {
            InitializeComponent();
        }

        public AuthorizeViewModel ViewModel
        {
            get { return DataContext as AuthorizeViewModel; }
            set { DataContext = value; }
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(ViewModel.Position))
                this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}

