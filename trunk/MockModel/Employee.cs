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

namespace MockModel
{
    public class Employee
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
            set 
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
            }
        }

        #endregion //Properties
    }
}
