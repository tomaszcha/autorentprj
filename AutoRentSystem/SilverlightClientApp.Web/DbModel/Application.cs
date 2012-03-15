using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverlightClientApp.Web.DbModel
{
    /// <summary>
    /// Describes application object to rent an auto
    /// </summary>
    public class Application
    {
        /// <summary>
        /// Unique identifier of the application
        /// </summary>
        public int Id { get; set; }


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
        public Model Model { get; set; }


        /// <summary>
        /// Expected date to pickup the auto
        /// </summary>
        public DateTime PickupDate { get; set; }


        /// <summary>
        /// Expected department to pickup the auto
        /// </summary>
        public Department PickupDepartment { get; set; }


        /// <summary>
        /// Expected date to return the auto
        /// </summary>
        public DateTime ReturnDate { get; set; }


        /// <summary>
        /// Expected department to return the auto
        /// </summary>
        public Department ReturnDepartment { get; set; }


        /// <summary>
        /// Customer preference about the auto (e.g., color)
        /// </summary>
        public string Preference { get; set; }


        /// <summary>
        /// Status of the application
        /// </summary>
        public string Status { get; set; }
    }
}