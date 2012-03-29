using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using System.Windows;
using ModuleInfrastracture.Views;
using EmployeeModule;
using UserRegistrationModule;
using AutoModule;
using CustomerModule;
using DamageClassModule;


namespace Main
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
            Shell shell = new Shell();
            return shell;
        }

        protected override void InitializeShell()
        {
            //initialize shell
            base.InitializeShell();

            //register shell in container
            Container.RegisterInstance((IShellPage)Shell);

            //set the delegate that is used to the current container retrieve
            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(Container));

            UIElement mainPage = (UIElement)Shell;
            Application.Current.RootVisual = mainPage;
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            ModuleCatalog moduleCatalog = (ModuleCatalog)ModuleCatalog;
            //moduleCatalog.AddModule(typeof(UserRegistrationModule.UserRegistrationModule));
            //moduleCatalog.AddModule(typeof(EmployeeModule.EmployeeModule));
            //moduleCatalog.AddModule(typeof(AutoModule.AutoModule));
            //moduleCatalog.AddModule(typeof(CustomerModule.CustomerModule));
            //moduleCatalog.AddModule(typeof(DamageClassModule.DamageClassModule));
            //moduleCatalog.AddModule(typeof(DepartmentModule.DepartmentModule));
            //moduleCatalog.AddModule(typeof(CustomerMenuModule.CustomerMenuModule));
            moduleCatalog.AddModule(typeof(GeneralManagerManu.ManagerModule));
            moduleCatalog.AddModule(typeof(EmployeeModule.EmployeeModule));
            moduleCatalog.AddModule(typeof(CustomerModule.CustomerModule));
            moduleCatalog.AddModule(typeof(AutoModule.AutoModule));

        }

        #endregion Overrides of Bootstrapper
    }
}
