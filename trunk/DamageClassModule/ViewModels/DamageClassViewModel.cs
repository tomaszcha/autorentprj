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
    /// <summary>
    /// This class provides a UI-friendly wrapper for the DamageClass object
    /// and contains properties that an DamageClassView can data bind to
    /// </summary>  
    public class DamageClassViewModel : ViewModelBase, IDataErrorInfo
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
                
        #endregion //Properties

        #region IDataErrorInfo

        public string Error
        {
            get { return (this as IDataErrorInfo).Error; }
        }

        public string this[string columnName]
        {
            get
            {
                string error;

                switch (columnName)
                {                    
                    case "Name":
                        error = ValidateName();
                        break;                                    
                    default:
                        error = (this as IDataErrorInfo)[columnName];
                        break;
                }

                return error;
            }
        }
        
        private string ValidateName()
        {
            string res = String.Empty;

            if (string.IsNullOrEmpty(_name))
            {
                res = Properties.Resources.EmptyField;
            }
            else if (_name.Length > 150)
            {
                res = Properties.Resources.LongString;
            }
            return res;
        }
               
        #endregion // IDataErrorInfo
    }
}
