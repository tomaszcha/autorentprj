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

namespace DamageClassModule.ViewModels
{
    public class DamageClassViewModel : ViewModelBase, IDataErrorInfo
    {
        /// <summary>
    /// This class provides a UI-friendly wrapper for the DamageClass object
    /// and contains properties that an DamageClassView can data bind to
    /// </summary>  
    public class EmployeeViewModel : ViewModelBase, IDataErrorInfo
    {
        #region PrivateFields

        int _class;
        string _name;
        string _description;       

        #endregion // Private fields

        #region Properties


        /// <summary>
        /// Unique class of the damage
        /// </summary>
        public int Class
        {
            get { return _class; }
            private set
            {
                _class = value;
                OnPropertyChanged("Class");
            }
        }


        /// <summary>
        /// Name of the damage class
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
        /// Description of the damage class
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
