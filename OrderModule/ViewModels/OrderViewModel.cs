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
using System.ComponentModel;
using System.Text.RegularExpressions;
using MockModel;
using Microsoft.Practices.Prism.Events;
using OrderModule.Events;
using CommandsInfrastracture;
using EventInfrastracture;
using Microsoft.Practices.Prism.Commands;
using ModuleInfrastracture.ViewModels;
using EventInfrastracture;

namespace OrderModule.ViewModels
{
    /// <summary>
    /// This class provides a UI-friendly wrapper for the Order object
    /// and contains properties that an OrderView can data bind to
    /// </summary>  
    public class OrderViewModel : ViewModelBase, IOrderViewModel, IDataErrorInfo
    {
        #region Constructors

        public OrderViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<OrderSelect>().Subscribe(onOrderSelect);
            _eventAggregator.GetEvent<MenuDictinaryEvent>().Subscribe(onEventTypeChange);
        }

        public OrderViewModel(Order order, IEventAggregator eventAggregator)
        {

            _eventAggregator = eventAggregator;
            if (order.Number == 0)
            {
                _eventAggregator.GetEvent<OrderSelect>().Subscribe(onOrderSelect);
                _eventAggregator.GetEvent<MenuDictinaryEvent>().Subscribe(onEventTypeChange);
                EventType = CommandsTypes.Edit;
            }

            _number = order.Number;
            _autoNumber = order.AutoNumber;
            _customerId = order.CustomerId;
            _managerId = order.ManagerId;
            _creationDate = order.CreationDate;
            _expiredDate = order.ExpiredDate;
            _departmentId = order.DepartmentId;
            _type = order.Type;
            _status = order.Status;
            _description = order.Description;
            _data = order.Data;            
        }

        #endregion Constructors

        #region Private Fields

        private IEventAggregator _eventAggregator;
        private OrderViewModel _order;
        private DelegateCommand _saveCommand;
        private DelegateCommand _cancelCommand;

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

        public string EventType { get; set; }

        /// <summary>
        /// Unique order number
        /// </summary>
        public int Number
        {
            get { return _number; }
            set
            {
                _number = value;
                OnPropertyChanged("Number");
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
                OnPropertyChanged("AutoNumber");
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
                OnPropertyChanged("CustomerId");
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
                OnPropertyChanged("ManagerId");
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
                OnPropertyChanged("reationDate");
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
                OnPropertyChanged("ExpiredDate");
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
                OnPropertyChanged("DepartmentId");
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
                OnPropertyChanged("Type");
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
                OnPropertyChanged("Status");
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
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Data
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


        /// <summary>
        /// Template
        /// </summary>
        public string Template
        {
            get { return _template; }
            set
            {
                _template = value;
                OnPropertyChanged("Template");
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
                    case "Number":
                    case "AutoNumber":
                    case "ManagerId":
                    case "CustomerId":
                    case "CreationDate":
                    case "ExpiredDate":
                    case "DepartmentId":
                    case "Type":
                    case "Status":
                    case "Description":
                    case "Data":
                    case "Template":
                        break;
                    default:
                        error = (this as IDataErrorInfo)[columnName];
                        break;
                }
                return error;
            }
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

        public void onOrderSelect(OrderViewModel order)
        {
            if (order == null) return;
            _order = order;
            if (EventType == CommandsTypes.Edit || order.Number == 0)
            {
                Number = order.Number;
                AutoNumber = order.AutoNumber;
                CustomerId = order.CustomerId;
                ManagerId = order.ManagerId;
                CreationDate = order.CreationDate;
                ExpiredDate = order.ExpiredDate;
                DepartmentId = order.DepartmentId;
                Type = order.Type;
                Status = order.Status;
                Description = order.Description;
                Data = order.Data;
            }
        }

        public void onEventTypeChange(string typeName)
        {
            EventType = typeName;
            switch (EventType)
            {
                case CommandsTypes.Edit:
                    onOrderSelect(_order);
                    break;
                case CommandsTypes.New:
                    onOrderSelect(new OrderViewModel(new Order(), _eventAggregator));
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
            onOrderSelect(_order);
        }

        #endregion Helpers
    }
}
