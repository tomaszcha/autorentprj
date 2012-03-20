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
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using DBMock;
using System.Collections.ObjectModel;
using Microsoft.Practices.Prism.Events;
using CustomerModule.Events;

namespace CustomerModule.ViewModels
{
    public class ApplicationCreateViewModel : ViewModelBase, IApplicationCreateViewModel, IDataErrorInfo
    {
        #region Constructor

        public ApplicationCreateViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
            eventAggregator.GetEvent<SelectEvent>().Subscribe(onSelectModel);
            _cities = new ObservableCollection<CityViewModel>();
            DeptsPickup = new ObservableCollection<DepartmentViewModel>();
            DeptsReturn = new ObservableCollection<DepartmentViewModel>();
            GetCityList();
            CityPickup = _cities[0];
            CityReturn = _cities[0];
            DeptPickUp = DeptsPickup[0];
            DeptReturn = DeptsReturn[0];
            PickupDate = DateTime.Today.Date;
            ReturnDate = DateTime.Today.Date.AddDays(3);
        }

        #endregion Constructor

        #region Fields

        #region public

        public ObservableCollection<CityViewModel> CitiesList { get { return _cities; } }
        public ObservableCollection<DepartmentViewModel> DeptsPickup { get; set; }
        public ObservableCollection<DepartmentViewModel> DeptsReturn { get; set; }
        public CityViewModel CityPickup 
        {
            get { return _cityPickup; }
            set
            {
                _cityPickup = value;
                GetDepartmentList(_cityPickup, DeptsPickup);
            }
        }

        public CityViewModel CityReturn
        {
            get { return _cityReturn; }
            set
            {
                _cityReturn = value;
                GetDepartmentList(_cityReturn, DeptsReturn);
            }
        }

        public DepartmentViewModel DeptPickUp
        {
            get { return _deptPickup; }
            set
            {
                _deptPickup = value;
            }
        }

        public DepartmentViewModel DeptReturn
        {
            get { return _deptReturn; }
            set
            {
                _deptReturn = value;
            }
        }

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
        public DateTime CreationDate 
        {
            get { return _creationDate; }
            set { _creationDate = value; }
        }    

        /// <summary>
        /// Customer first name
        /// </summary>
        public string FirstName 
        {
            get { return _firstName; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    _firstName = value;
            }
        }

        /// <summary>
        /// Customer last name
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    _lastName = value;
            }
        }

        /// <summary>
        /// Customer contact phone number
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

        /// <summary>
        /// Customer email address
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    _email = value;
            }
        }

        /// <summary>
        /// Auto model
        /// </summary>
        public ModelViewModel Model 
        {
            get { return _model; }
            set { _model = value; } 
        }

        /// <summary>
        /// Expected date to pickup the auto
        /// </summary>
        public DateTime PickupDate
        {
            get { return _pickupDate; }
            set { _pickupDate = value; }
        }

        /// <summary>
        /// Expected department to pickup the auto
        /// </summary>
        public DepartmentViewModel PickupDepartment 
        {
            get { return _pickupDepartment; }
            set { _pickupDepartment = value; }
        }  

        /// <summary>
        /// Expected date to return the auto
        /// </summary>
        public DateTime ReturnDate
        {
            get { return _returnDate; }
            set { _returnDate = value; }
        }

        /// <summary>
        /// Expected department to return the auto
        /// </summary>
        public DepartmentViewModel ReturnDepartment
        {
            get { return _returnDepartment; }
            set { _returnDepartment = value; }
        }  

        /// <summary>
        /// Customer preference about the auto (e.g., color)
        /// </summary>
        public string Preference
        {
            get { return _preference; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    _preference = value;
            }
        }

        /// <summary>
        /// Status of the application
        /// </summary>
        public string Status
        {
            get { return _status; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    _status = value;
            }
        }

        #endregion public

        #region private

        private ObservableCollection<CityViewModel> _cities;
        private CityViewModel _cityPickup;
        private CityViewModel _cityReturn;
        private DepartmentViewModel _deptPickup;
        private DepartmentViewModel _deptReturn;
        private IEventAggregator eventAggregator;

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

        private DepartmentViewModel _pickupDepartment { get; set; }

        private string _preference { get; set; }

        private string _status { get; set; } 

        #endregion private

        #endregion Fields

        #region Methods

        public void onSelectModel(ModelViewModel model)
        {
            Model = model;
        }

        private void GetCityList()
        {
            _cities.Clear();
            List<CityViewModel> list = (from model in new Cities().List
                                         select new CityViewModel(model)).ToList();
            foreach(CityViewModel city in list)
            {
                _cities.Add(city);
            }
        }

        private void GetDepartmentList(CityViewModel city, ObservableCollection<DepartmentViewModel> depts)
        {
            depts.Clear();
            List<DepartmentViewModel> list = (from model in new Departmens().List.Where(o=>o.City.Id==city.Id)
                          select new DepartmentViewModel(model)).ToList();
            foreach (DepartmentViewModel dept in list)
            {
                depts.Add(dept);
            }
        }

        private void Send()
        {
            //send application
            FirstName = "";
            LastName = "";  

            MessageBox.Show(new Random().Next(15231, 9999).ToString());
        }

        #endregion Methods

        #region IDataErrorInfo members

        public string this[string columnName]
        {
            get
            {
                string error;
                if (columnName == "FirstName" || columnName == "LastName")
                    error = ValidateName();
                else if (columnName == "Phone")
                    error = ValidatePhone();
                else if (columnName == "Email")
                    error = ValidateEmail();
                else if (columnName == "PickupDate")
                    error = ValidatePickupDate();
                else if (columnName == "ReturnDate")
                    error = ValidateReturnDate();
                else error = (this as IDataErrorInfo)[columnName];
                return error;
            }
        }

        string ValidateName()
        {
            string res = null;
            if (_firstName == null)
                return "Missing";
            if (_firstName.Length > 20)
                res = "Too long";

            return res;
        }

        string ValidatePhone()
        {
            if (_phone == null)
                return "Missing";
            const string pat = @"(^\([0]\d{2}\))(\d{6,7}$)";
            if (!Regex.IsMatch(_phone, pat))
                return "Invalid phone number (example (063)1234567)";
            return null;
        }

        string ValidateEmail()
        {
            if (_email == null)
                return "Missing";
            const string pat = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                             + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				                        [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                             + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				                        [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                             + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";
            if (!Regex.IsMatch(_email, pat))
                return "Invalid  email address";
            return null;
        }

        string ValidatePickupDate()
        {
            string res = "";
            if (_pickupDate < DateTime.Today.Date)
                res = "Sellect another date";
            return res;
        }

        string ValidateReturnDate()
        {
            string res = "";
            if (_returnDate < DateTime.Today.Date.AddDays(1))
                res = "Sellect another date";
            return res;
        }

        public string Error
        {
            get { return (this as IDataErrorInfo).Error; }
        }

        #endregion IDataErrorInfo members

        
    }
}
