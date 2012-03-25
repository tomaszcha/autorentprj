using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.Events;

namespace ModuleInfrastracture
{
    /// <summary>
    /// Base class for all modules
    /// </summary>
    public abstract class ModuleBase : IModule
    {
        [Dependency]
        public IUnityContainer UnityContainer { get; set; }

        [Dependency]
        public IRegionManager RegionManager { get; set; }

        [Dependency]
        public IEventAggregator EventAggregator { get; set; }

        /// <summary>
        /// Notifies the module that it has be initialized.
        /// </summary>
        public void Initialize()
        {
            RegisterTypesDependencies();
            RegisterViewsInRegions();
        }

        protected abstract void RegisterViewsInRegions();
        protected abstract void RegisterTypesDependencies();
    }
}
