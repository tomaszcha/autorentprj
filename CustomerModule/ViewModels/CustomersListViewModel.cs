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
using System.Collections.ObjectModel;
using Microsoft.Practices.Prism.Commands;
using MockModel;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Prism.Events;
using CustomerModule.Events;


namespace CustomerModule.ViewModels
{
    public class CustomersListViewModel : ViewModelBase, ICustomersListViewModel
    {
        #region Constructor

        public CustomersListViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            _customers = new ObservableCollection<CustomerViewModel>();
            GetCustomersList();
        }

        #endregion Constructor

        #region PrivateFields

        private ObservableCollection<CustomerViewModel> _customers;

        private CustomerViewModel _curCustomer;

        IEventAggregator _eventAggregator;

        //private DelegateCommand 

        #endregion PrivateFields

        #region Properties

        public ObservableCollection<CustomerViewModel> Customers 
        {
            get { return _customers; }
            set { _customers = value; }
        }

        public CustomerViewModel CurCustomer
        {
            get { return _curCustomer; }
            set
            {
                _curCustomer = value;
                onCustomerSelect(value);
            }
        }

        #endregion Properties

        #region Commands

        

        #endregion Commands

        #region Helpers

        private void GetCustomersList()
        {
            _customers.Clear();
            List<CustomerViewModel> list = (from model in new Customers().List
                                            select new CustomerViewModel(model, _eventAggregator)).ToList();
            foreach (CustomerViewModel model in list)
            {
                _customers.Add(model);
            }   
        }

        private void onCustomerSelect(CustomerViewModel cust)
        {
            _eventAggregator.GetEvent<CustomerSelect>().Publish(cust);
        }

        #endregion Helpers
    }
}
