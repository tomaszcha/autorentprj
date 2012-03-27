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
using System.Text.RegularExpressions;

namespace EmployeeModule.ViewModels
{
    /// <summary>
    /// This class provides a UI-friendly wrapper for the Employee object
    /// and contains properties that an EmployeeView can data bind to
    /// </summary>  
    public class EmployfeViewModel : ViewModelBase, IDataErrorInfo
    {
        #region Private Fields

        Guid _id;
        string _firstName;
        string _lastName;
        DateTime _birthDay;
        string _position;
        int _departmentId;
        string _address;
        string _phone;
        DateTime _hireDate;
        DateTime _fireDate;
        string _insuaranceNumber;
        string _licenceNumber;       
        string _data;

        #endregion // Private fields

        #region Properties


        /// <summary>
        /// Unique employee id
        /// </summary>
        public Guid Id
        {
            get { return _id; }
            private set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }


        /// <summary>
        /// First name of the employee
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }


        /// <summary>
        /// Last name of the employee
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }


        /// <summary>
        /// Birthday of the employee
        /// </summary>
        public DateTime BirthDay
        {
            get { return _birthDay; }
            set
            {
                _birthDay = value;
                OnPropertyChanged("BirthDay");
            }
        }


        /// <summary>
        /// Position of the employee
        /// </summary>
        public string Position
        {
            get { return _position; }
            set
            {
                _birthDay = value;
                OnPropertyChanged("Position");
            }
        }


        /// <summary>
        /// Department id 
        /// </summary>
        public int DepartmentId
        {
            get { return _departmentId; }
            set
            {
                _departmentId = value;
                OnPropertyChanged("DepartmentId");
            }
        }
        

        /// <summary>
        /// Address of the employee
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
        /// Phone of the employee
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


        /// <summary>
        /// Hire date of the employee
        /// </summary>
        public DateTime HireDate
        {
            get { return _hireDate; }
            set
            {
                _hireDate = value;
                OnPropertyChanged("HireDate");
            }
        }


        /// <summary>
        /// Birthday of the employee
        /// </summary>
        public DateTime FireDate
        {
            get { return _fireDate; }
            set
            {
                _fireDate = value;
                OnPropertyChanged("FireDate");
            }
        }

        /// <summary>
        /// Insuarance number of the employee
        /// </summary>
        public string InsuaranceNumber
        {
            get { return _insuaranceNumber; }
            set
            {
                _insuaranceNumber = value;
                OnPropertyChanged("InsuaranceNumber");
            }
        }


        /// <summary>
        /// Licence number of the employee
        /// </summary>
        public string LicenceNumber
        {
            get { return _licenceNumber; }
            set
            {
                _licenceNumber = value;
                OnPropertyChanged("LicenceNumber");
            }
        }

               
        /// <summary>
        /// Other employee data
        /// </summary>
        public string Data
        {
            get { return _data; }
            set
            {
                _data = value;
                OnPropertyChanged("Data");
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
                    case "FirstName":
                    case "LastName":
                        error = ValidateName();
                        break;
                    case "Position":
                        error = ValidatePosition();
                        break;
                    case "Address":
                        error = ValidateAddress();
                        break;
                    case "Phone":
                        error = ValidatePhone();
                        break;
                    case "InsuaranceNumber":
                    case "LicenceNumber":
                        error = ValidateInsuarLicenceNumber();
                        break;                   
                    case "BirthDay":
                        error = ValidateBirthDay();
                        break;
                    case "HireDate":
                        error = ValidateHireDate();
                        break;
                    case "FireDate":
                        error = ValidateFireDate();
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
            if (string.IsNullOrEmpty(_firstName) || string.IsNullOrEmpty(_lastName))
            {
                res = Properties.Resources.EmptyField;
            }
            else if (_firstName.Length > 50 || _lastName.Length > 50)
            {
                res = Properties.Resources.LongString;
            }
            return res;
        }

        private string ValidatePosition()
        {
            string res = String.Empty;
            if (string.IsNullOrEmpty(_position))
            {
                res = Properties.Resources.EmptyField;
            }
            else if (_position.Length > 10)
            {
                res = Properties.Resources.LongString;
            }
            return res;
        }

        private string ValidateAddress()
        {
            string res = String.Empty;
            if (_address.Length > 150)
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
            else if (_phone.Length > 16)
            {
                res = Properties.Resources.LongString;
            }
            else if (!Regex.IsMatch(_phone, Properties.Resources.PhoneRegEx))
            {
                res = Properties.Resources.InvalidPhone;
            }
            return res;
        }

        private string ValidateInsuarLicenceNumber()
        {
            string res = String.Empty;
            if (_insuaranceNumber.Length > 26 || _licenceNumber.Length > 26)
            {
                res = Properties.Resources.LongString;
            }
            return res;
        }               

        private string ValidateBirthDay()
        {
            string res = String.Empty;
            if (_birthDay > System.DateTime.Today.AddYears(-16))
            {
                res = Properties.Resources.InvalidDate;
            }
            return res;
        }

        private string ValidateHireDate()
        {
            string res = String.Empty;
            if(_hireDate > System.DateTime.Today)
            {
                res = Properties.Resources.InvalidDate;
            }
            return res;
        }       
        
        private string ValidateFireDate()
        {
            string res = String.Empty;
            if(_fireDate > System.DateTime.Today)
            {
                res = Properties.Resources.InvalidDate;
            }
            return res;
        }     


        #endregion // IDataErrorInfo
    }
}
