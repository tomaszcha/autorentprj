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

namespace MockModel
{
    public class Auto
    {
        #region Private Fields

        string _number;
        string _modelName;
        int _bodyType;
        string _insuranceNumber;
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
            }
        }


        /// <summary>
        /// Insuarance number of the auto
        /// </summary>
        public string InsuranceNumber
        {
            get { return _insuranceNumber; }
            set
            {
                _insuranceNumber = value;
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
            }
        }

        #endregion //Properties
    }
}
