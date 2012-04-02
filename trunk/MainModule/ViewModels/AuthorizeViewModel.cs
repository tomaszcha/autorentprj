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
using System.ComponentModel;
using Microsoft.Practices.Prism.Commands;

namespace MainModule.ViewModels
{
    public class AuthorizeViewModel : ViewModelBase, IAuthorizeViewModel, IDataErrorInfo
    {
        #region Private Fields

        private DelegateCommand<string> _authorizeCommand;

        private string _login;
        private string _position;

        #endregion // Private fields

        #region Properties


        /// <summary>
        /// User login
        /// </summary>
        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                OnPropertyChanged("Login");
            }
        }

        public string Position
        {
            get { return _position; }
            set
            {
                _position = value;
                OnPropertyChanged("Position");
            }
        }

        #endregion //Properties

        #region IDataErrorInfo

        public string Error
        {
            get { return (this as IDataErrorInfo).Error; }
        }

        public string this[string columnName]
        {
            get
            {
                string error;

                switch (columnName)
                {
                    case "Login":
                        error = ValidateLogin();
                        break;
                    default:
                        error = (this as IDataErrorInfo)[columnName];
                        break;
                }
                return error;
            }
        }


        private string ValidateLogin()
        {
            string res = String.Empty;
            if (string.IsNullOrEmpty(_login))
            {
                res = Properties.Resources.EmptyField;
            }
            else if (_login.Length > 50)
            {
                res = Properties.Resources.LongString;
            }
            return res;
        }

        #endregion // IDataErrorInfo

        #region Commands

        public ICommand AuthorizeCommand
        {
            get 
            {
                if (_authorizeCommand == null)
                    _authorizeCommand = new DelegateCommand<string>(AuthorizeExecute);
                return _authorizeCommand;
            }
        }

        #endregion Commands

        #region Helpers

        private void AuthorizeExecute(string pessword)
        {
            Position = "Manager";
            Application.Current.MainWindow.Close();
        }

        #endregion Helpers
    }
}
