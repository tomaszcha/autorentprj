using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

//prism
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;

namespace SilverlightClientApp 
{
    public class Bootstrapper : UnityBootstrapper
    {
        #region Overrides of Bootstrapper

        protected override DependencyObject CreateShell()
        {
            Shell shell = new Shell();
            return shell;
        }

        protected override void InitializeShell()
        {
            //initialize shell
            base.InitializeShell();

            //register shell in container
            Container.RegisterInstance((IShellWindow)Shell);

            //set the delegateyhat is used to the current container retrieve
            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(Container));

            //Window mainWindow = (Window)Shell;
            //Application.Current.MainWindow = mainWindow;
            //Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            ModuleCatalog moduleCatalog = (ModuleCatalog)ModuleCatalog;
            //moduleCatalog.AddModule(typeof(PersonsListModule));;
        }

        #endregion Overrides of Bootstrapper
    }
}
