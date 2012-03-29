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

    public class Order
    {
        #region Private Fields

        int _number;
        string _autoNumber;
        Guid _customerId;
        Guid _managerId;
        DateTime _creationDate;
        DateTime _expiredDate;
        Guid _departmentId;
        int _type;
        int _status;
        string _description;
        string _data;
        string _template;      

        #endregion // Private fields

        #region Properties


        /// <summary>
        /// Unique order number
        /// </summary>
        public int Number
        {
            get { return _number; }
            set
            {
                _number = value;
            }
        }


        /// <summary>
        /// Auto number
        /// </summary>
        public string AutoNumber
        {
            get { return _autoNumber; }
            set
            {
               _autoNumber = value;
            }
        }


        /// <summary>
        /// Customer id
        /// </summary>
        public Guid CustomerId
        {
            get { return _customerId; }
            set
            {
                _customerId = value;
            }
        }


        /// <summary>
        /// Manager id
        /// </summary>
        public Guid ManagerId
        {
            get { return _managerId; }
            set
            {
                _managerId = value;
            }
        }


        /// <summary>
        /// Creation date
        /// </summary>
        public DateTime CreationDate
        {
            get { return _creationDate; }
            set
            {
                _creationDate = value;
            }
        }


        /// <summary>
        /// Expired date
        /// </summary>
        public DateTime ExpiredDate
        {
            get { return _expiredDate; }
            set
            {
                _expiredDate = value;
            }
        }


        /// <summary>
        /// Department id
        /// </summary>
        public Guid DepartmentId
        {
            get { return _departmentId; }
            set
            {
                _departmentId = value;
            }
        }


        /// <summary>
        /// Type of the order
        /// </summary>
        public int Type
        {
            get { return _type; }
            set
            {
                _type = value;
            }
        }


        /// <summary>
        /// Status of the order
        /// </summary>
        public int Status
        {
            get { return _status; }
            set
            {
                _status = value;
            }
        }


        /// <summary>
        /// Description of the order
        /// </summary>
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
            }
        }

        /// <summary>
        /// Data
        /// </summary>
        public string InsuaranceNumber
        {
            get { return _data; }
            set
            {
                _data = value;
            }
        }


        /// <summary>
        /// Template
        /// </summary>
        public string Template
        {
            get { return _template; }
            set
            {
                _template = value;
            }
        }             

        #endregion //Properties
    }
}
