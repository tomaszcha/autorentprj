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
using ModelMock;
using System.ComponentModel;

namespace ModulesInfrastructure.ViewModels
{
    public class ModelViewModel : ViewModelBase, IDataErrorInfo
    {
        #region Constructor

        public ModelViewModel(Model model)
        {
            _dayRate = model.DayRate;
            _deposit = model.Deposit;
            _engineCapacity = model.EngineCapacity;
            _hourRate = model.HourRate;
            _id = model.Id;
            _name = model.Name;
            _photo = model.Photo;
            _seats = model.Seats;
            Make = new MakeViewModel(model.Make);
        }

        #endregion Constructor

        #region Data

        #region public

        /// <summary>
        /// Unique identifier of the auto model
        /// </summary>
        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }       

        /// <summary>
        /// Name of the auto model
        /// </summary>
        public string Name 
        {
            get { return _name; }
            set
            {
                if (!String.IsNullOrEmpty(_name))
                    _name = value;
            }
        }

        /// <summary>
        /// Make of the auto model
        /// </summary>
        public MakeViewModel Make;

        /// <summary>
        /// Number of seats of the auto model
        /// </summary>
        public int Seats 
        {
            get { return _seats; }
            set
            {
                if (value > 0)
                {
                    _seats = value;
                }
            }
        }  

        /// <summary>
        /// Engine capacity of the auto
        /// </summary>
        public string EngineCapacity 
        {
            get { return _engineCapacity; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _engineCapacity = value;
                }
            }
        }

        /// <summary>
        /// Photo of the auto model
        /// </summary>
        public byte[] Photo 
        {
            get { return _photo; }
            set { _photo = value; } 
        }

        /// <summary>
        /// Rental rate of one hour 
        /// </summary>
        public float HourRate 
        {
            get { return _hourRate; }
            set 
            {
                if (value > 0)
                {
                    _hourRate = value;
                }
            } 
        }

        /// <summary>
        /// Rental rate of one day
        /// </summary>
        public float DayRate 
        {
            get { return _dayRate; }
            set
            {
                if (value > 0)
                {
                    _dayRate = value;
                }
            } 
        }

        /// <summary>
        /// Deposit for the rental auto
        /// </summary>
        public float Deposit 
        {
            get { return _deposit; }
            set
            {
                if (value >= 0)
                {
                    _deposit = value;
                }
            }
        }         

        /// <summary>
        /// category of the auto
        /// </summary>
        public CategoryViewModel Category;

        #endregion public

        #region private

        private int _id;

        private string _name;

        private int _seats;

        private string _engineCapacity;

        private byte[] _photo;

        private float _hourRate;

        private float _dayRate;

        private float _deposit;

        #endregion private

        #endregion Data

        #region IDataErrorInfo members

        public string Error
        {
            get { return (this as IDataErrorInfo).Error; }
        }

        public string this[string columnName]
        {
            get
            {
                string error = (this as IDataErrorInfo)[columnName];

                //CommandManager.InvalidateRequerySuggested();
                return error;
            }
        }

        #endregion IDataErrorInfo members
    }
}
