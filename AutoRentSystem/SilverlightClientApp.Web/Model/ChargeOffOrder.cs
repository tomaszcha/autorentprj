using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverlightClientApp.Web.Model
{
    /// <summary>
    /// Describes charge-off order object
    /// </summary>
    public class ChargeOffOrder
    {
        /// <summary>
        /// Unique identifier of the charge-off order
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// The auto to charge off
        /// </summary>
        public Auto Auto { get; set; }


        /// <summary>
        /// The reason for auto charge-off
        /// </summary>
        public string Reason { get; set; }


        /// <summary>
        /// Mechanic who proposes to charge off the auto
        /// </summary>
        public Employee Mechanic { get; set; }


        /// <summary>
        /// Manager who accepts mechanic proposition to charge off the auto
        /// </summary>
        public Employee Manager { get; set; }


        /// <summary>
        /// Status of the charge-off order
        /// </summary>
        public string Status { get; set; }
    }
}