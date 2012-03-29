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
using ModuleInfrastracture.ViewModels;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Commands;
using EventInfrastracture;

namespace GeneralManagerManu.ViewModels
{
    public class ManagerViewModel : ViewModelBase, IManagerViewModel
    {
        #region Constructor

        public ManagerViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }                         

        #endregion Constructor

        #region PrivateFields

        private IEventAggregator _eventAggregator;

        private DelegateCommand<string> _menuActionCommand;

        #endregion PrivateFields

        #region Commands

        public ICommand MenuActionCommand
        {
            get 
            {
                if (_menuActionCommand == null)
                    _menuActionCommand = new DelegateCommand<string>(MenuActionExecute);
                return _menuActionCommand;
            }
        }

        #endregion Commands

        #region Helpers

        private void MenuActionExecute(string typeName)
        {
            _eventAggregator.GetEvent<MenuEmployeeEvent>().Publish(typeName);
        }

        #endregion Helpers
    }
}
