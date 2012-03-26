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
using System.Windows.Shapes;
using ModuleInfrastracture.ViewModels;
using System.ComponentModel;

namespace DepartmentModule.ViewModels
{
    /// <summary>
    /// This class provides a UI-friendly wrapper for the Department object
    /// and contains properties that an DepartmentView can data bind to
    /// </summary>  
    public class DepartmentViewModel : ViewModelBase, IDataErrorInfo
    {
        #region PrivateFields

        int _id;
        int _cityCode;
        string _name;
        string _address;
        string _phone;

        #endregion // Private fields

        #region Properties


        /// <summary>
        /// Unique identifier of the department
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
        /// Code of the city where department is located
        /// </summary>
        public int CityCode
        {
            get { return _cityCode; }
            set
            {
                _cityCode = value;
                OnPropertyChanged("cityCode");
            }
        }


        /// <summary>
        /// Name of the department
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
        /// Address of the department
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
        /// Phone of the department
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
