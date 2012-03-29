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
using EmployeeModule.Events;

namespace EmployeeModule.ViewModels
{
    public class EmployeesListViewModel : ViewModelBase, IEmployeeListViewModel
    {

        #region Constructor

        public EmployeesListViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            _employees = new ObservableCollection<EmployeeViewModel>();
            GetEmployeesList();
        }

        #endregion Constructor

        #region PrivateFields

        private ObservableCollection<EmployeeViewModel> _employees;

        private EmployeeViewModel _curEmployee;

        IEventAggregator _eventAggregator;

        //private DelegateCommand 

        #endregion PrivateFields

        #region Properties

        public ObservableCollection<EmployeeViewModel> Employees 
        {
            get { return _employees; }
            set { _employees = value; }
        }

        public EmployeeViewModel CurEmployee
        {
            get { return _curEmployee; }
            set
            { 
                _curEmployee = value;
                omEmployeeSelect(value);
            }
        }

        #endregion Properties

        #region Commands

        

        #endregion Commands

        #region Helpers

        private void GetEmployeesList()
        {
            _employees.Clear();
            List<EmployeeViewModel> list = (from model in new Employees().List
                                         select new EmployeeViewModel(model, _eventAggregator)).ToList();
            foreach (EmployeeViewModel model in list)
            {
                _employees.Add(model);
            }   
        }

        private void omEmployeeSelect(EmployeeViewModel empl)
        {
            _eventAggregator.GetEvent<EmployeeSelect>().Publish(empl);
        }

        #endregion Helpers
    }
}
