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

namespace AutoModule.ViewModels
{
    /// <summary>
    /// This class provides a UI-friendly wrapper for the Auto object
    /// and contains properties that an AutoView can data bind to
    /// </summary>   
    public class AutoViewModel : ViewModelBase, IDataErrorInfo
    {

        #region PrivateFields

        string _number;
        string _modelName;
        int _bodyType;
        string _insuaranceId;
        short _class;
        short _year;
        short _mileage;
        int _engine;
        string _colorGroup;
        decimal _dayRate;
        decimal _kmRate;
        short _status;
        decimal _advance;
        
        #endregion // Private fields
        
        #region Properties


        /// <summary>
        /// Auto number
        /// </summary>
        public string Number
        {
            get { return _number; }
            set 
            { 
                _number = value;
                OnPropertyChanged("Number");
            }
        }

        /// <summary>
        /// Name of the auto model
        /// </summary>
        public string ModelName
        {
            get { return _modelName; }
            set
            {
                _modelName = value;
                OnPropertyChanged("Modelname");
            }
        }


        /// <summary>
        /// Type of the auto body
        /// </summary>
        public int BodyType
        {
            get { return _bodyType; }
            set
            {
                _bodyType = value;
                OnPropertyChanged("BodyType");
            }
        }


        /// <summary>
        /// Insuarance number of the auto
        /// </summary>
        public string InsuaranceNumber
        {
            get { return _insuaranceId; }
            set
            {
                _insuaranceId = value;
                OnPropertyChanged("InsuaranceId");
            }
        }


        /// <summary>
        /// Class of the auto
        /// </summary>
        public short Class 
        {
            get { return _class; }
            set
            {
                _class = value;
                OnPropertyChanged("Class");
            }
        }


        /// <summary>
        /// Production year of the auto
        /// </summary>
        public short Year
        {
            get { return _year; }
            set
            {
                _year = value;
                OnPropertyChanged("Year");
            }
        }


        /// <summary>
        /// Current mileage of the auto
        /// </summary>
        public short Mileage 
        { 
            get { return _mileage; }
            set
            {
                _mileage = value;
                OnPropertyChanged("Mileage");
            }
        }


        /// <summary>
        /// Engine capacity
        /// </summary>
        public int Engine
        {
            get { return _engine; }
            set
            {
                _engine = value;
                OnPropertyChanged("Engine");
            }
        }


        /// <summary>
        /// Color of the auto
        /// </summary>
        public string ColorGroup
        {
            get { return _colorGroup; }
            set
            {
                _colorGroup = value;
                OnPropertyChanged("ColorGroup");
            }
        }


        /// <summary>
        /// Rental rate per one day
        /// </summary>
        public decimal DayRate
        {
            get { return _dayRate; }
            set
            {
                _dayRate = value;
                OnPropertyChanged("DayRate");
            }
        }


        /// <summary>
        /// Rental rate per km
        /// </summary>
        public decimal KmRate
        {
            get { return _kmRate; }
            set
            {
                _kmRate = value;
                OnPropertyChanged("KmRate");
            }
        }

          
        /// <summary>
        /// Status of the auto auto
        /// </summary>
        public short Status
        {
            get { return _status; }
            set
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }


        /// <summary>
        /// Advance for the auto
        /// </summary>
        public decimal Advance
        {
            get { return _advance; }
            set
            {
                _advance = value;
                OnPropertyChanged("Advance");
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
