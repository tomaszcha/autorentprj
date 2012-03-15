using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverlightClientApp.Web.DbModel
{
    /// <summary>
    /// Describes purchaser object
    /// </summary>
    public class Purchaser
    {
        /// <summary>
        /// Unique identifier of the purchaser
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// City where the purchaser is located
        /// </summary>
        public City City { get; set; }


        /// <summary>
        /// Address within the city where the purchaser is located
        /// </summary>
        public string Address { get; set; }


        /// <summary>
        /// Contact phone number of the purchaser
        /// </summary>
        public string Phone { get; set; }
    }
}