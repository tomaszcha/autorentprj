using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverlightClientApp.Web.Model
{
    /// <summary>
    /// Describes technical service object
    /// </summary>
    public class TechnicalService
    {
        /// <summary>
        /// Unique identifier of the technical service
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Name of the technical service
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// City where the technical service is located
        /// </summary>
        public City City { get; set; }


        /// <summary>
        /// Address of the technical service within the city
        /// </summary>
        public string Address { get; set; }


        /// <summary>
        /// Technical service contact phone number
        /// </summary>
        public string Phone { get; set; }
    }
}