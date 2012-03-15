using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverlightClientApp.Web.Model
{
    /// <summary>
    /// Describes model object of the auto
    /// </summary>
    public class Model
    {
        /// <summary>
        /// Unique identifier of the auto model
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Name of the auto model
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Make of the auto model
        /// </summary>
        public Make Make { get; set; }


        /// <summary>
        /// Number of seats of the auto model
        /// </summary>
        public int Seats { get; set; }


        /// <summary>
        /// Engine capacity of the auto
        /// </summary>
        public string EngineCapacity { get; set; }


        /// <summary>
        /// Photo of the auto model
        /// </summary>
        public byte[] Photo { get; set; }


        /// <summary>
        /// Rental rate of one hour 
        /// </summary>
        public float KmRate { get; set; }


        /// <summary>
        /// Rental rate of one day
        /// </summary>
        public float DayRate { get; set; }


        /// <summary>
        /// Deposit for the rental auto
        /// </summary>
        public float Deposit { get; set; }


        /// <summary>
        /// category of the auto
        /// </summary>
        public Category Category { get; set; }
    }
}