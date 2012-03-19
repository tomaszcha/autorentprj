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

namespace CustomerModule.ViewModels
{
    public class ApplicationCreateViewModel : ViewModelBase, IApplicationCreateViewModel
    {
        #region Constructor
        #endregion Constructor

        #region Fields

        #region public

        /// <summary>
        /// Unique identifier of the application
        /// </summary>
        public int Id 
        {
            get { return _id; }
            private set { _id = value; }
        }   

        /// <summary>
        /// A date of the application creation
        /// </summary>
        public DateTime CreationDate { get; set; }    

        /// <summary>
        /// Customer first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Customer last name
        /// </summary>
        public string LastName { get; set; }   

        /// <summary>
        /// Customer contact phone number
        /// </summary>
        public string Phone { get; set; }  

        /// <summary>
        /// Customer email address
        /// </summary>
        public string Email { get; set; }   

        /// <summary>
        /// Auto model
        /// </summary>
        public ModelViewModel Model { get; set; }

        /// <summary>
        /// Expected date to pickup the auto
        /// </summary>
        public DateTime PickupDate { get; set; }

        /// <summary>
        /// Expected department to pickup the auto
        /// </summary>
        public DepartmentViewModel PickupDepartment { get; set; }  

        /// <summary>
        /// Expected date to return the auto
        /// </summary>
        public DateTime ReturnDate { get; set; } 

        /// <summary>
        /// Expected department to return the auto
        /// </summary>
        public DepartmentViewModel ReturnDepartment { get; set; }  

        /// <summary>
        /// Customer preference about the auto (e.g., color)
        /// </summary>
        public string Preference { get; set; }  

        /// <summary>
        /// Status of the application
        /// </summary>
        public string Status { get; set; } 

        #endregion public

        #region private

        private int _id { get; set; }

        private DateTime _creationDate { get; set; }

        private string _firstName { get; set; }

        private string _lastName { get; set; }

        private string _phone { get; set; }

        private string _email { get; set; }

        private ModelViewModel _model { get; set; }

        private DateTime _pickupDate { get; set; }

        private DateTime _returnDate { get; set; }

        private DepartmentViewModel _returnDepartment { get; set; }

        private string _preference { get; set; }

        private string _status { get; set; } 

        #endregion private

        #endregion Fields
    }
}
