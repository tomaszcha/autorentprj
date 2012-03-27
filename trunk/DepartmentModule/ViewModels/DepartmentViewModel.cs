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
using System.Windows.Shapes;
using ModuleInfrastracture.ViewModels;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace DepartmentModule.ViewModels
{
    /// <summary>
    /// This class provides a UI-friendly wrapper for the Department object
    /// and contains properties that an DepartmentView can data bind to
    /// </summary>  
    public class DepartmentViewModel : ViewModelBase, IDataErrorInfo
    {
        #region PrivateFields

        int _id;
        int _cityCode;
        string _name;
        string _address;
        string _phone;

        #endregion // Private fields

        #region Properties


        /// <summary>
        /// Unique identifier of the department
        /// </summary>
        public int Id
        {
            get { return _id; }
            private set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }


        /// <summary>
        /// Code of the city where department is located
        /// </summary>
        public int CityCode
        {
            get { return _cityCode; }
            set
            {
                _cityCode = value;
                OnPropertyChanged("cityCode");
            }
        }


        /// <summary>
        /// Name of the department
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }


        /// <summary>
        /// Address of the department
        /// </summary>
        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged("Address");
            }
        }


        /// <summary>
        /// Phone of the department
        /// </summary>
        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                OnPropertyChanged("Phone");
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
                    case "Name":
                        error = ValidateName();
                        break;
                    case "Address":
                        error = ValidateAddress();
                        break;
                    case "Phone":
                        error = ValidatePhone();
                        break;                   
                    default:
                        error = (this as IDataErrorInfo)[columnName];
                        break;
                }
                return error;
            }
        }
        
        private string ValidateName()
        {
            string res = String.Empty;
            if (string.IsNullOrEmpty(_name))
            {
                res = Properties.Resources.EmptyField;
            }
            else if (_name.Length > 150)
            {
                res = Properties.Resources.LongString;
            }
            return res;
        }

        
        private string ValidateAddress()
        {
            string res = String.Empty;
            if (string.IsNullOrEmpty(_address))
            {
                res = Properties.Resources.EmptyField;
            }
            else if (_address.Length > 150)
            {
                res = Properties.Resources.LongString;
            }
            return res;
        }

        private string ValidatePhone()
        {
            string res = String.Empty;
            if (string.IsNullOrEmpty(_phone))
            {
                res = Properties.Resources.EmptyField;
            }
            if (_phone.Length > 24)
            {
                res = Properties.Resources.LongString;
            }
            else if (!Regex.IsMatch(_phone, Properties.Resources.PhoneRegEx))
            {
                res = Properties.Resources.InvalidPhone;
            }
            return res;
        }
               
        #endregion // IDataErrorInfo
    }
}
