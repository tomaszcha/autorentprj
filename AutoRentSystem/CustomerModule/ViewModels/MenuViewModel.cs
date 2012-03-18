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
using ModulesInfrastructure.ViewModels;
using System.ComponentModel;
using Microsoft.Practices.Prism.Events;
using EventInfrastracture;
using Microsoft.Practices.Prism.Commands;

namespace CustomerModule.ModelViews
{
    /// <summary>
    /// Module for work with main menu
    /// </summary>
    public class MenuViewModel  : ViewModelBase, IMenuViewModel
    {
        #region Constructor

        public MenuViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
        }

        #endregion Constructor

        #region Fields

        private IEventAggregator eventAggregator;

        private DelegateCommand<string> _onMenuCliclCommand;

        #endregion Fields

        #region Commands

        /// <summary>
        /// Happens when you click a menu item. The module is loaded into the right area.
        /// </summary>
        public ICommand OnMenuCliclCommand
        {
            get
            {
                if (_onMenuCliclCommand == null)
                {
                    _onMenuCliclCommand = new DelegateCommand<string>(OnMenuClick);
                }
                return _onMenuCliclCommand;
            }
        }

        #endregion Commands

        #region Private Helpers

        void OnMenuClick(string view)
        {
            eventAggregator.GetEvent<MenuEvent>().Publish(view);
        }

        #endregion Private Helpers

    }
}
