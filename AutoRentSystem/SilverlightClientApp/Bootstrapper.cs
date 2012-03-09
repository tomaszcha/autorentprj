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

using ModulesInfrastructure.Views;

namespace SilverlightClientApp 
{
    /// <summary>
    /// The basic purpose of our Bootstrapper is to initialize our Shall and register all 
    /// the types you’ll need for Dependency Injection (DI). Bootstrapper will responsible 
    /// to load and start our application.
    /// </summary>
    public class Bootstrapper : UnityBootstrapper
    {
        #region Overrides of Bootstrapper

        protected override DependencyObject CreateShell()
        {
            //return Container.Resolve<Shell>();
            Shell shell = new Shell();
            return shell;
        }

        protected override void InitializeShell()
        {
            //initialize shell
            base.InitializeShell();

            //register shell in container
            Container.RegisterInstance((IShellPage)Shell);

            //set the delegateyhat is used to the current container retrieve
            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(Container));

            UIElement mainPage = (UIElement)Shell;
            Application.Current.RootVisual = mainPage;
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            ModuleCatalog moduleCatalog = (ModuleCatalog)ModuleCatalog;
            moduleCatalog.AddModule(typeof(ApplicationCreate.ApplicationCreateModule));
            //moduleCatalog.AddModule(typeof(PersonsListModule));;
        }

        #endregion Overrides of Bootstrapper
    }
}
