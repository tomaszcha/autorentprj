﻿using System;
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
using ModulesInfrastructure.ViewModels;

namespace CustomerModule.ViewModels
{
    public class ModelViewModel : ViewModelBase, IDataErrorInfo
    {
        #region Constructor

        public ModelViewModel(Model model)
        {
            _dayRate = model.DayRate;
            _deposit = model.Deposit;
            _engine = model.Engine;
            _kmRate = model.KmRate;
            _id = model.Id;
            _name = model.Name;
            _photo = model.Photo;
            _seats = model.Seats;
            _category = model.Category;
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
        public MakeViewModel Make { get; set; }

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
        public string Engine 
        {
            get { return _engine; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _engine = value;
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
        /// Rental rate per km
        /// </summary>
        public float KmRate 
        {
            get { return _kmRate; }
            set 
            {
                if (value > 0)
                {
                    _kmRate = value;
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

        public short Category
        {
            get { return _category; }
            set
            {
                if (value >= 0)
                {
                    _category = value;
                }
            }
        }       

        #endregion public

        #region private

        private int _id;

        private string _name;

        private int _seats;

        private string _engine;

        private byte[] _photo;

        private float _kmRate;

        private float _dayRate;

        private float _deposit;

        private short _category;

        #endregion private

        #endregion Data

        #region IDataErrorInfo members

        public string this[string columnName]
        {
            get
            {
                string error;
                if (columnName == "Name")
                    error = ValidateName();
                else if (columnName == "Seats")
                    error = ValidateSeats();
                else if (columnName == "Engine")
                    error = ValidateEngine();
                else if (columnName == "Photo")
                    error = ValidatePhoto();
                else if (columnName == "KmRate" || columnName == "DayRate")
                    error = ValidateRate();
                else if (columnName == "Deposit")
                    error = ValidateDeposit();
                else if (columnName == "Category")
                    error = ValidateCategory();
                else error = (this as IDataErrorInfo)[columnName];
                return error;
            }
        }

        string ValidateName()
        {
            string res = null;
            if (_name == null)
                return "Missing";
            if (_name.Length > 20)
                res = "Too long";

            return res;
        }

        string ValidateSeats()
        {
            if (_seats == null)
                return "Missing";           
            return null;
        }

        string ValidateEngine()
        {
            if (_engine == null)
                return "Missing";            
            return null;
        }

        string ValidatePhoto()
        {
            return null;
        }

        string ValidateRate()
        {
            return null;
        }

        string ValidateDeposit()
        {
            return null;
        }

        string ValidateCategory()
        {
            return null;
        }

        public string Error
        {
            get { return (this as IDataErrorInfo).Error; }
        }

        #endregion IDataErrorInfo members
    }
}
