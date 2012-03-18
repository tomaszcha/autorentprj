﻿namespace MainHost
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Navigation;
    using MainHost.LoginUI;
    using ModulesInfrastructure.Views;
    using MainHost.Web.Services;

    /// <summary>
    /// <see cref="UserControl"/> class providing the main UI for the application.
    /// </summary>
    public partial class Shell : UserControl, IShellPage
    {
        /// <summary>
        /// Creates a new <see cref="Shell"/> instance.
        /// </summary>
        public Shell()
        {
            new MainHost.Web.Services.AutoRentDomainContext();

            InitializeComponent();
        }

        /// <summary>
        /// After the Frame navigates, ensure the <see cref="HyperlinkButton"/> representing the current page is selected
        /// </summary>
        private void ContentFrame_Navigated(object sender, NavigationEventArgs e)
        {
            //foreach (UIElement child in LinksStackPanel.Children)
            //{
            //    HyperlinkButton hb = child as HyperlinkButton;
            //    if (hb != null && hb.NavigateUri != null)
            //    {
            //        if (hb.NavigateUri.ToString().Equals(e.Uri.ToString()))
            //        {
            //            VisualStateManager.GoToState(hb, "ActiveLink", true);
            //        }
            //        else
            //        {
            //            VisualStateManager.GoToState(hb, "InactiveLink", true);
            //        }
            //    }
            //}
        }

        /// <summary>
        /// If an error occurs during navigation, show an error window
        /// </summary>
        private void ContentFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            e.Handled = true;
            ErrorWindow.CreateNew(e.Exception);
        }
    }
}