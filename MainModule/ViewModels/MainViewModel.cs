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
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Commands;
using EventInfrastracture;

namespace MainModule.ViewModels
{
    public class MainViewModel : IMainViewModel
    {
            #region Constructor

        public MainViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }                         

        #endregion Constructor

        #region PrivateFields

        private IEventAggregator _eventAggregator;

        private DelegateCommand<string> _menuCommand;    

        #endregion PrivateFields

        #region Commands

        public ICommand MenuCommand
        {
            get 
            {
                if (_menuCommand == null)
                    _menuCommand = new DelegateCommand<string>(MenuExecute);
                return _menuCommand;
            }
        }

        #endregion Commands

        #region Helpers

        private void MenuExecute(string typeName)
        {
            _eventAggregator.GetEvent<MenuEvent>().Publish(typeName);
        }

        #endregion Helpers
    }
}
