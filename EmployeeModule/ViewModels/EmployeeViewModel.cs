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
using MockModel;
using Microsoft.Practices.Prism.Events;
using EmployeeModule.Events;
using CommandsInfrastracture;
using EventInfrastracture;
using Microsoft.Practices.Prism.Commands;
using System.ServiceModel.DomainServices.Client; 

namespace EmployeeModule.ViewModels
{
    /// <summary>
    /// This class provides a UI-friendly wrapper for the Employee object
    /// and contains properties that an EmployeeView can data bind to
    /// </summary>  
    public class EmployeeViewModel : ViewModelBase, IEmployeeViewModel, IDataErrorInfo
    {

        #region Constructors

        public EmployeeViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<EmployeeSelect>().Subscribe(onEmployeeSelect);
            _eventAggregator.GetEvent<MenuDictinaryEvent>().Subscribe(onEventTypeChange);
        }

        public EmployeeViewModel(Employee employee, IEventAggregator eventAggregator)
        {

            _eventAggregator = eventAggregator;
            if (employee.Id == Guid.Empty)
            {
                _eventAggregator.GetEvent<EmployeeSelect>().Subscribe(onEmployeeSelect);
                _eventAggregator.GetEvent<MenuDictinaryEvent>().Subscribe(onEventTypeChange);
                EventType = CommandsTypes.Edit;
            }

            _address = employee.Address;
            _birthDay = employee.BirthDay;
            _data = employee.Data;
            _departmentId = employee.DepartmentId;
            _fireDate = employee.FireDate;
            _firstName = employee.FirstName;
            _hireDate = employee.HireDate;
            _id = employee.Id;
            _insuranceNumber = employee.InsuranceNumber;
            _lastName = employee.LastName;
            _licenceNumber = employee.LicenceNumber;
            _phone = employee.Phone;
            _position = employee.Position;
        }

        #endregion Constructors

        #region Private Fields

        private IEventAggregator _eventAggregator;

        private EmployeeViewModel _employee;

        private DelegateCommand _saveCommand;

        private DelegateCommand _cancelCommand;

        private Guid _id;
        private string _firstName;
        private string _lastName;
        private DateTime _birthDay;
        private string _position;
        private int _departmentId;
        private string _address;
        private string _phone;
        private DateTime _hireDate;
        private DateTime _fireDate;
        private string _insuranceNumber;
        private string _licenceNumber;
        private string _data;

        #endregion // Private fields

        #region Properties   

        public string EventType { get; set; }

        /// <summary>
        /// Unique employee id
        /// </summary>
        public Guid Id
        {
            get { return _id; }
            private set
            {
                _id = value;
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
                _position = value;
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
                //OnPropertyChanged("DepartmentId");
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
        /// Insurance number of the employee
        /// </summary>
        public string InsuranceNumber
        {
            get { return _insuranceNumber; }
            set
            {
                _insuranceNumber = value;
                OnPropertyChanged("InsuarnceNumber");
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
                //OnPropertyChanged("Data");
            }
        }

        #endregion //Properties

        #region IDataErrorInfo

        public string Error
        {
            get
            {
                string err = "";
                if (this is IDataErrorInfo)
                    err = (this as IDataErrorInfo).Error;
                return err;
            }
        }

        public string this[string columnName]
        {
            get
            {
                string error = "";

                switch (columnName)
                {
                    case "Id":
                        break;
                    case "Data":
                        break;
                    case "DepartmentId":
                        break;
                    case "FirstName":
                        break;
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
                        error = ValidateInsurNumber();
                        break;
                    case "LicenceNumber":
                        error = ValidateLicenceNumber();
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
                    //default:
                    //    error = (this as IDataErrorInfo)[columnName];
                    //    break;
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
            if (_address!=null)
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

        private string ValidateInsurNumber()
        {
            string res = String.Empty;
            if (_insuranceNumber!=null)
                if (_insuranceNumber.Length > 26)
                {
                    res = Properties.Resources.LongString;
                }
            return res;
        }

        private string ValidateLicenceNumber()
        {
            string res = String.Empty;
            if (_licenceNumber != null)
                if (
                    _licenceNumber.Length > 26)
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

        #region Commands

        public ICommand SaveCommand
        {
            get
            {
                if (_saveCommand == null)
                    _saveCommand = new DelegateCommand(SaveExecute);
                return _saveCommand;
            }
        }

        public ICommand CancelCommand
        {
            get
            {
                if (_cancelCommand == null)
                    _cancelCommand = new DelegateCommand(CancelExecute);
                return _cancelCommand;
            }
        }

        #endregion Commands

        #region Helpers

        public void onEmployeeSelect(EmployeeViewModel employee)
        {
            if (employee == null) return;
            _employee = employee;
            if (EventType == CommandsTypes.Edit || employee.Id == Guid.Empty)
            {
                Address = employee.Address;
                BirthDay = employee.BirthDay;
                Data = employee.Data;
                DepartmentId = employee.DepartmentId;
                FireDate = employee.FireDate;
                FirstName = employee.FirstName;
                HireDate = employee.HireDate;
                Id = employee.Id;
                InsuranceNumber = employee.InsuranceNumber;
                LastName = employee.LastName;
                LicenceNumber = employee.LicenceNumber;
                Phone = employee.Phone;
                Position = employee.Position;
            }
        }

        public void onEventTypeChange(string typeName)
        {
            EventType = typeName;
            switch (EventType)
            {
                case CommandsTypes.Edit:
                    onEmployeeSelect(_employee);
                    break;
                case CommandsTypes.New:
                    onEmployeeSelect(new EmployeeViewModel(new Employee(), _eventAggregator));
                    break;
            }
        }

        private void SaveExecute()
        {
            if (EventType == CommandsTypes.New) { };
            if (EventType == CommandsTypes.Edit) { };
        }

        private void CancelExecute()
        {
            onEmployeeSelect(_employee);
        }

        #endregion Helpers
    }
}
