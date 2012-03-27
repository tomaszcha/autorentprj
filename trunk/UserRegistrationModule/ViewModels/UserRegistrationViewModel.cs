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
using UserRegistrationModule.ViewModels;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace UserRegistrationModule.ViewModels
{
    public class UserRegistrationViewModel : ViewModelBase, IUserRegistrationViewModel, IDataErrorInfo
    {
        #region Private Fields

        string _login;
        string _password;
        string _email;
        DateTime _created;
        
        #endregion // Private fields

        #region Properties


        /// <summary>
        /// User login
        /// </summary>
        public string Login
        {
            get { return _login; }
            private set
            {
                _login = value;
                OnPropertyChanged("Login");
            }
        }


        /// <summary>
        /// User password
        /// </summary>
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }


        /// <summary>
        /// User email
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged("Email");
            }
        }


        /// <summary>
        /// Date of the creation
        /// </summary>
        public DateTime Created
        {
            get { return _created; }
            set
            {
                _created = value;
                OnPropertyChanged("Created");
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
                    case "Password":
                        error = ValidatePassword();
                        break;
                    case "Email":
                        error = ValidateEmail();
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

        private string ValidatePassword()
        {
            string res = String.Empty;
            if (string.IsNullOrEmpty(_password))
            {
                res = Properties.Resources.EmptyField;
            }
            else if (_password.Length > 10)
            {
                res = Properties.Resources.LongString;
            }
            return res;
        }

        private string ValidateEmail()
        {
            string res = String.Empty;
            if (string.IsNullOrEmpty(_email))
            {
                res = Properties.Resources.EmptyField;
            }
            else if(!Regex.IsMatch(_email, Properties.Resources.EmailRegEx))
            {
                res = Properties.Resources.InvalidEmail;
            }
            else if (_email.Length > 150)
            {
                res = Properties.Resources.LongString;
            }
            return res;
        }
              
        #endregion // IDataErrorInfo
    }
}
