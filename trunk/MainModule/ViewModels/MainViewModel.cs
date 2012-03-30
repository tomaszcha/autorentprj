using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using ModuleInfrastracture.ViewModels;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Commands;
using EventInfrastracture;
using System.Windows.Input;
using MainModule.Views;

namespace MainModule.ViewModels
{
    public class MainViewModel : ViewModelBase, IMainViewModel
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

        private DelegateCommand _authorizeCommand;

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

        public ICommand AuthorizeCommand
        {
            get
            {
                if (_authorizeCommand == null)
                    _authorizeCommand = new DelegateCommand(AuthorizeExecute);
                return _authorizeCommand;
            }
        }

        #endregion Commands

        #region Helpers

        private void MenuExecute(string typeName)
        {
            _eventAggregator.GetEvent<MenuEvent>().Publish(typeName);
        }

        private void AuthorizeExecute()
        {
            AuthorizeViewModel vm = new AuthorizeViewModel();
            AuthorizeView view = new AuthorizeView();
            view.ViewModel = vm;
            view.Show();
            
        }

        #endregion Helpers
    }
}
