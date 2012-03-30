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
using CustomerModule.Events;
using CommandsInfrastracture;
using EventInfrastracture;
using Microsoft.Practices.Prism.Commands;

namespace CustomerModule.ViewModels
{
    /// <summary>
    /// This class provides a UI-friendly wrapper for the Customer object
    /// and contains properties that an CustomerView can data bind to
    /// </summary>  
    public class CustomerViewModel : ViewModelBase, ICustomerViewModel, IDataErrorInfo
    {
        #region Constructors

        public CustomerViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<CustomerSelect>().Subscribe(onCustomerSelect);
            _eventAggregator.GetEvent<MenuDictinaryEvent>().Subscribe(onEventTypeChange);

        }

        public CustomerViewModel(Customer customer, IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            if (customer.Id == Guid.Empty)
            {
                _eventAggregator.GetEvent<CustomerSelect>().Subscribe(onCustomerSelect);
                _eventAggregator.GetEvent<MenuDictinaryEvent>().Subscribe(onEventTypeChange);
                EventType = CommandsTypes.Edit;
            }

            _id = customer.Id;
            _name = customer.Name;
            _type = customer.Type;
            _address = customer.Address;
            _phone = customer.Phone;
            _insuaranceNumber = customer.InsuaranceNumber;
            _licenceNumber = customer.LicenceNumber;
            _passport = customer.Passport;
            _birthDay = customer.BirthDay;
            _data = customer.Data;
        }

        #endregion Constructors

        #region Private Fields

        Guid _id;
        string _name;
        string _type;
        string _address;
        string _phone;
        string _insuaranceNumber;
        string _licenceNumber;
        string _passport;
        DateTime _birthDay;
        string _data;

        IEventAggregator _eventAggregator;
        CustomerViewModel _customer;
        DelegateCommand _saveCommand;
        DelegateCommand _cancelCommand;

        #endregion // Private fields

        #region Properties

        public string EventType { get; set; }

        /// <summary>
        /// Unique customer ids
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
        /// Name of the customer
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
        /// Type of the customer
        /// </summary>
        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("Type");
            }
        }


        /// <summary>
        /// Address of the customer
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
        /// Phone of the customer
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
        /// Insuarance number of the customer
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
        /// Licence number of the customer
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
        /// Passport of the customer
        /// </summary>
        public string Passport
        {
            get { return _passport; }
            set
            {
                _passport = value;
                OnPropertyChanged("Passport");
            }
        }


        /// <summary>
        /// Birthday of the customer
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
        /// Other customer data
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
                    case "Name":
                        error = ValidateName();
                        break;
                    case "Type":
                        error = ValidateType();
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
                    case "Passport":
                        error = ValidatePassport();
                        break;
                    case "BirthDay":
                        error = ValidateBirthDay();
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

        private string ValidateType()
        {
            string res = String.Empty;
            if (string.IsNullOrEmpty(_type))
            {
                res = Properties.Resources.EmptyField;
            }
            else if (_type.Length > 25)
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
            if (_phone.Length > 16)
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

        private string ValidatePassport()
        {
            string res = String.Empty;
            if (_passport.Length > 26)
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

        public void onCustomerSelect(CustomerViewModel customer)
        {
            if (customer == null) return;

            _customer = customer;

            if (EventType == CommandsTypes.Edit || customer.Id == Guid.Empty)
            {
                Id = customer.Id;
                Name = customer.Name;
                Type = customer.Type;
                Address = customer.Address;
                Phone = customer.Phone;
                InsuaranceNumber = customer.InsuaranceNumber;
                LicenceNumber = customer.LicenceNumber;
                Passport = customer.Passport;
                BirthDay = customer.BirthDay;
                Data = customer.Data;
            }
        }

        public void onEventTypeChange(string typeName)
        {
            EventType = typeName;
            switch (EventType)
            {
                case CommandsTypes.Edit:
                    onCustomerSelect(_customer);
                    break;
                case CommandsTypes.New:
                    onCustomerSelect(new CustomerViewModel(new Customer(), _eventAggregator));
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
            onCustomerSelect(_customer);
        }

        #endregion Helpers
    }
}
