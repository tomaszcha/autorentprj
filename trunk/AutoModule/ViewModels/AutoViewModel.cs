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
using System.Text.RegularExpressions;
using MockModel;
using Microsoft.Practices.Prism.Events;
using AutoModule.Events;
using CommandsInfrastracture;
using EventInfrastracture;
using Microsoft.Practices.Prism.Commands;

namespace AutoModule.ViewModels
{
    /// <summary>
    /// This class provides a UI-friendly wrapper for the Auto object
    /// and contains properties that an AutoView can data bind to
    /// </summary>   
    public class AutoViewModel : ViewModelBase, IAutoViewModel, IDataErrorInfo
    {

        #region Constructors

        public AutoViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<AutoSelect>().Subscribe(onAutoSelect);
            _eventAggregator.GetEvent<MenuDictinaryEvent>().Subscribe(onEventTypeChange);

        }

        public AutoViewModel(Auto auto, IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            if (String.IsNullOrEmpty(auto.Number))
            {
                _eventAggregator.GetEvent<AutoSelect>().Subscribe(onAutoSelect);
                _eventAggregator.GetEvent<MenuDictinaryEvent>().Subscribe(onEventTypeChange);
                EventType = CommandsTypes.Edit;
            }

            _number = auto.Number;
            _modelName = auto.ModelName;
            _bodyType = auto.BodyType;
            _insuaranceNumber = auto.InsuaranceNumber;
            _class = auto.Class;
            _year = auto.Year;
            _mileage = auto.Mileage;
            _engine = auto.Engine;
            _colorGroup = auto.ColorGroup;
            _dayRate = auto.DayRate;
            _kmRate = auto.KmRate;
            _status = auto.Status;
            _advance = auto.Advance;         
        }

        #endregion Constructors
        
        #region PrivateFields

        string _number;
        string _modelName;
        int _bodyType;
        string _insuaranceNumber;
        short _class;
        short _year;
        short _mileage;
        int _engine;
        string _colorGroup;
        decimal _dayRate;
        decimal _kmRate;
        short _status;
        decimal _advance;


        IEventAggregator _eventAggregator;
        AutoViewModel _auto;
        DelegateCommand _saveCommand;
        DelegateCommand _cancelCommand;
        
        #endregion // Private fields
        
        #region Properties

        public string EventType { get; set; }

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
            get { return _insuaranceNumber; }
            set
            {
                _insuaranceNumber = value;
                OnPropertyChanged("InsuaranceNumber");
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
            get { return (this as IDataErrorInfo).Error; }
        }

        public string this[string columnName]
        {
            get
            {
                string error;

                switch (columnName)
                {
                    case "Number":
                        error = ValidateAutoNumber();
                        break;
                    case "ModelName":
                        error = ValidateModelName();
                        break;
                    case "BodyType":
                        error = ValidateBodyType();
                        break;
                    case "InsuaranceNumber":
                        error = ValidateInsuaranceNumber();
                        break;
                    case "Class":
                        error = ValidateClass();
                        break;
                    case "Year":
                        error = ValidateYear();
                        break;
                    case "Mileage":
                        error = ValidateMileage();
                        break;
                    case "Engine":
                        error = ValidateEngine();
                        break;                   
                    case "ColorGroup":
                        error = ValidateColorGroup();
                        break;
                    case "DayRate":
                    case "KmRate":
                    case "Advance":
                        error = ValidateRate();
                        break;
                    case "Status":
                        error = ValidateStatus();
                        break;
                    default:
                        error = (this as IDataErrorInfo)[columnName];
                        break;
                }
                return error;
            }
        }


        private string ValidateAutoNumber()
        {
            string res = String.Empty;
            if (string.IsNullOrEmpty(_number))
            {
                res = Properties.Resources.EmptyField;
            }
            else if (_number.Length > 10)
            {
                res = Properties.Resources.LongString;
            }
            return res;
        }

        private string ValidateModelName()
        {
            string res = String.Empty;
            if (string.IsNullOrEmpty(_modelName))
            {
                res = Properties.Resources.EmptyField;
            }
            else if (_modelName.Length > 75)
            {
                res = Properties.Resources.LongString;
            }
            return res;
        }

        private string ValidateBodyType()
        {
            string res = String.Empty;                  
            return res;
        }

        private string ValidateInsuaranceNumber()
        {
            string res = String.Empty;
            if (string.IsNullOrEmpty(_insuaranceNumber))
            {
                res = Properties.Resources.EmptyField;
            }
            else if (_insuaranceNumber.Length > 24)
            {
                res = Properties.Resources.LongString;
            }
            return res;
        }

        private string ValidateClass()
        {
            string res = String.Empty;               
            return res;
        }
        
        private string ValidateYear()
        {
            string res = String.Empty; 
            if (_year < 1950 || _year > System.DateTime.Today.Year)
            {
                res = Properties.Resources.InvalidDate;
            }
            return res;
        }
        
        private string ValidateMileage()
        {
            string res = String.Empty;                    
            return res;
        }
        
        private string ValidateEngine()
        {
            string res = String.Empty;           
            return res;
        }
        
        private string ValidateColorGroup()
        {
            string res = String.Empty;            
            return res;
        }
        
        private string ValidateRate()
        {
            string res = String.Empty;
            if (_dayRate < 0 || _kmRate < 0 || _advance < 0)
            {
                res = Properties.Resources.EmptyField;
            }
            return res;
        }
        
        private string ValidateStatus()
        {
            string res = String.Empty;            
            return res;
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

        public void onAutoSelect(AutoViewModel auto)
        {
            if (auto == null) return;

            _auto = auto;

            if (EventType == CommandsTypes.Edit || String.IsNullOrEmpty(auto.Number))
            {
                Number = auto.Number;
                ModelName = auto.ModelName;
                BodyType = auto.BodyType;
                InsuaranceNumber = auto.InsuaranceNumber;
                Class  = auto.Class;
                Year = auto.Year;
                Mileage = auto.Mileage;
                Engine = auto.Engine;
                ColorGroup = auto.ColorGroup;
                DayRate = auto.DayRate;
                KmRate = auto.KmRate;
                Status = auto.Status;
                Advance = auto.Advance;        

            }
        }

        public void onEventTypeChange(string typeName)
        {
            EventType = typeName;
            switch (EventType)
            {
                case CommandsTypes.Edit:
                    onAutoSelect(_auto);
                    break;
                case CommandsTypes.New:
                    onAutoSelect(new AutoViewModel(new Auto(), _eventAggregator));
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
            onAutoSelect(_auto);
        }

        #endregion Helpers
    }
}
