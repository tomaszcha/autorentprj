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

namespace EmployeeModule.ViewModels
{
    /// <summary>
    /// This class provides a UI-friendly wrapper for the Employee object
    /// and contains properties that an EmployeeView can data bind to
    /// </summary>  
    public class EmployeeViewModel : ViewModelBase, IDataErrorInfo
    {
        #region PrivateFields

        int _id;
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
        /// Department id 
        /// </summary>
        public int Departmentid
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
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get { throw new NotImplementedException(); }
        }

        #endregion // IDataErrorInfo
    }
}
