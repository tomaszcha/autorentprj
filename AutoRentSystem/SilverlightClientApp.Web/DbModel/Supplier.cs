using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverlightClientApp.Web.DbModel
{
    /// <summary>
    /// Describes supplier object
    /// </summary>
    public class Supplier
    {
        /// <summary>
        /// Unique identifier of the supplier
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// City where the supplier is located
        /// </summary>
        public City City { get; set; }


        /// <summary>
        /// Address within the city where supplier is located
        /// </summary>
        public string Address { get; set; }


        /// <summary>
        /// Contact phone of the supplier
        /// </summary>
        public string Phone { get; set; }
    }
}