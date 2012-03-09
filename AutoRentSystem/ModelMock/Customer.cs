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

namespace ModelMock
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
