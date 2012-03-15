using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverlightClientApp.Web.DbModel
{
    /// <summary>
    /// Describes customer object
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Unique identifier of the customer
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// First name of the customer
        /// </summary>
        public string FirstName { get; set; }


        /// <summary>
        /// Last name of the customer
        /// </summary>
        public string LastName { get; set; }


        /// <summary>
        /// Customer insuarance number
        /// </summary>
        public string Insuarance { get; set; }


        /// <summary>
        /// Customer passport data
        /// </summary>
        public string Passport { get; set; }


        /// <summary>
        /// Customer contact phone number
        /// </summary>
        public string Phone { get; set; }


        /// <summary>
        /// Customer email address
        /// </summary>
        public string Email { get; set; }
    }
}