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
using OrderModule.Events;

namespace OrderModule.ViewModels
{
    public class OrdersListViewModel : ViewModelBase, IOrdersListViewModel
    {
        #region Constructor

        public OrdersListViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            _orders = new ObservableCollection<OrderViewModel>();
            GetOrdersList();
        }

        #endregion Constructor

        #region PrivateFields

        private ObservableCollection<OrderViewModel> _orders;

        private OrderViewModel _curOrder;

        IEventAggregator _eventAggregator;

        //private DelegateCommand 

        #endregion PrivateFields

        #region Properties

        public ObservableCollection<OrderViewModel> Orders 
        {
            get { return _orders; }
            set { _orders = value; }
        }

        public OrderViewModel CurOrder
        {
            get { return _curOrder; }
            set
            {
                _curOrder = value;
                onOrderSelect(value);
            }
        }

        #endregion Properties

        #region Commands

        
        #endregion Commands

        #region Helpers

        private void GetOrdersList()
        {
            _orders.Clear();
            List<OrderViewModel> list = (from model in new Orders().List
                                        select new OrderViewModel(model, _eventAggregator)).ToList();
            foreach (OrderViewModel model in list)
            {
                _orders.Add(model);
            }  
        }

        private void onOrderSelect(OrderViewModel order)
        {
            _eventAggregator.GetEvent<OrderSelect>().Publish(order);
        }

        #endregion Helpers
    }
}
