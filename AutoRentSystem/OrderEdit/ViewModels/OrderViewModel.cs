using System;
using System.ComponentModel;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using ModelMock;

namespace OrderEdit.ViewModels
{
    /// <summary>
    /// This class provides a UI-friendly wrapper for the Order object
    /// and contains properties that an OrderView can data bind to
    /// </summary>
    public class OrderViewModel : ViewModelBase, IOrderViewModel, IDataErrorInfo
    {
        #region Fields

        private int _id;
        private DateTime _creationDate;
        private DateTime _closingDate;
        private Customer _customer;
        private Auto _auto;
        private DateTime _pickupDate;
        private Department _pickupDepartment;
        private DateTime _returnDate;
        private Department _returnDepartment;
        private string _status;
        private string _rentType;
        private string _paymentType;
        private float _payment;

        #endregion // Fields

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public OrderViewModel() { }


        /// <summary>
        /// This constructor takes an Order object as a parameter
        /// </summary>
        /// <param name="order">Order object</param>
        public OrderViewModel(Order order)
        {
            _id = order.Id;
            _creationDate = order.CreationDate;
            _closingDate = order.ClosingDate;
            _customer = order.Customer;
            _auto = order.Auto;
            _pickupDate = order.PickupDate;
            _pickupDepartment = order.PickupDepartment;
            _returnDate = order.ReturnDate;
            _returnDepartment = order.ReturnDepartment;
            _status = order.Status;
            _rentType = order.RentType;
            _paymentType = order.PaymentType;
            _payment = order.Payment;
        }

        #endregion // Constructor

        #region Properties
        
        /// <summary>
        /// Unique identifier of the rental order
        /// </summary>
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }


        /// <summary>
        /// The date of the order creation
        /// </summary>
        public DateTime CreationDate
        {
            get { return _creationDate; }
            set
            {
                _creationDate = value;
                OnPropertyChanged("CreationDate");
            }
        }


        /// <summary>
        /// The date of the order closing
        /// </summary>
        public DateTime ClosingDate
        {
            get { return _closingDate; }
            set
            {
                _closingDate = value;
                OnPropertyChanged("ClosingDate");
            }
        }


        /// <summary>
        /// Customer who makes order
        /// </summary>
        public Customer Customer 
        {
            get { return _customer; }
            set
            {
                _customer = value;
                OnPropertyChanged("Customer");
            }
        }


        /// <summary>
        /// The auto to rent
        /// </summary>
        public Auto Auto
        {
            get { return _auto; }
            set
            {
                _auto = value;
                OnPropertyChanged("Auto");
            }
        }


        /// <summary>
        /// The auto pick-up date
        /// </summary>
        public DateTime PickupDate
        {
            get { return _pickupDate; }
            set
            {
                _pickupDate = value;
                OnPropertyChanged("PickupDate");
            }
        }


        /// <summary>
        /// The department of the auto pick-up
        /// </summary>
        public Department PickupDepartment
        {
            get { return _pickupDepartment; }
            set
            {
                _pickupDepartment = value;
                OnPropertyChanged("PickupDepartment");
            }
        }


        /// <summary>
        /// The auto return date
        /// </summary>
        public DateTime ReturnDate
        {
            get { return _returnDate; }
            set
            {
                _returnDate = value;
                OnPropertyChanged("ReturnDate");
            }
        }


        /// <summary>
        ///  The department of the auto return
        /// </summary>
        public Department ReturnDepartment
        {
            get { return _returnDepartment; }
            set
            {
                _returnDepartment = value;
                OnPropertyChanged("ReturnDepartment");
            }
        }


        /// <summary>
        /// Status of the order
        /// </summary>
        public string Status
        {
            get { return _status; }
            set
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }


        /// <summary>
        /// Type of the rent
        /// </summary>
        public string RentType
        {
            get { return _rentType; }
            set
            {
                _rentType = value;
                OnPropertyChanged("RentType");
            }
        }


        /// <summary>
        /// Type of the payment
        /// </summary>
        public string PaymentType
        {
            get { return _paymentType; }
            set
            {
                _paymentType = value;
                OnPropertyChanged("PaymentType");
            }
        }


        /// <summary>
        /// Value of the payment
        /// </summary>
        public float Payment
        {
            get { return _payment; }
            set
            {
                _payment = value;
                OnPropertyChanged("Payment");
            }
        }

        #endregion //Properties

        #region Implementation of IDataErrorInfo

        public string this[string columnName]
        {
            get { throw new NotImplementedException(); }
        }

        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        #endregion // Implementation of IDataErrorInfo
    }
}
