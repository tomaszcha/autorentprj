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

namespace CustomerModule.ViewModels
{
    public class CustomerViewModel : ViewModelBase, IDataErrorInfo
    {
        #region PrivateFields

        int _id;
        string _name;
        string _type;
        string _address
        string _phone;
        string _insuaranceNumber;
        string _licenceNumber;
        string _passport;
        DateTime _birthDay;
        string _data;

        #endregion // Private fields

        #region Properties


        /// <summary>
        /// Unique customer id
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
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get { throw new NotImplementedException(); }
        }

        #endregion // IDataErrorInfo
    }
}
