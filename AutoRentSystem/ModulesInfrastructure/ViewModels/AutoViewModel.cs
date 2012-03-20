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

namespace ModulesInfrastructure.ViewModels
{
    public class AutoShotViewModel : ViewModelBase
    {
        #region Data

        #region Public

        /// <summary>
        /// Unique identifier of the auto
        /// </summary>
        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        /// <summary>
        /// Number of the auto
        /// </summary>
        public string Number 
        {
            get { return _number; }
            set 
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _number = value;
                }
            } 
        }

        /// <summary>
        /// Insuarance number of the auto
        /// </summary>
        public Insuarance Insuarance
        {
            get { return _insuarance; }
            set
            {
                if (value != null)
                {
                    //value.
                }
            } 
        }


        /// <summary>
        /// Model of the auto
        /// </summary>
        public Model Model { get; set; }


        /// <summary>
        /// Production year of the auto
        /// </summary>
        public short Year { get; set; }


        /// <summary>
        /// Current mileage of the auto
        /// </summary>
        public int Mileage { get; set; }


        /// <summary>
        /// Color of the auto
        /// </summary>
        public string Color { get; set; }


        /// <summary>
        /// Last check date of the auto
        /// </summary>
        public DateTime LastCheckDate { get; set; }

        // Current mileage of the auto
        /// </summary>
        public short Category { get; set; }


        /// <summary>
        /// Additional information about the auto
        /// </summary>
        public string Description { get; set; }

        #endregion public

        #region private

        private int _id;

        private string _number;

        private Insuarance _insuarance;

        private Model _model { get; set; }

        private short _category { get; set; }

        private short _year { get; set; }

        private int _mileage { get; set; }

        private string _color { get; set; }

        private DateTime _lastCheckDate { get; set; }

        private string _description { get; set; }

        #endregion private

        #endregion Data
    }
}
