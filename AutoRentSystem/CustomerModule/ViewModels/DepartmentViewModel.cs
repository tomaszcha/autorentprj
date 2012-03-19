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
using ModulesInfrastructure.ViewModels;
using ModelMock;

namespace CustomerModule.ViewModels
{
    public class DepartmentViewModel : ViewModelBase
    {
        #region Constructor

        public DepartmentViewModel(Department department)
        { }

        #endregion Constructor

        #region Fields

        #region public

        /// <summary>
        /// Unique identifier of the department
        /// </summary>
        public int Id 
        {
            get { return _id; }
            private set { _id = value; }
        }        

        /// <summary>
        /// City where the department is located
        /// </summary>
        public CityViewModel City 
        {
            get { return _city; }
            set
            {
                if (value != null)
                    _city = value;
            }
        }           

        /// <summary>
        /// Address of the department within the city 
        /// </summary>
        public string Address 
        {
            get { return _address; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    _address = value;
            }
        }               

        /// <summary>
        /// Contact phone number of the department
        /// </summary>
        public string Phone
        {
            get { return _phone; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    _phone = value;
            }
        }

        #endregion public

        #region private

        private int _id;

        private CityViewModel _city;

        private string _address;

        private string _phone;

        #endregion private

        #endregion Fields
    }
}
