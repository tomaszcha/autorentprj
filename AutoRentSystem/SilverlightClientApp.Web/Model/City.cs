using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverlightClientApp.Web.Model
{
    /// <summary>
    /// Describes city object
    /// </summary>
    public class City
    {
        /// <summary>
        /// Unique identifier of the city
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// City name
        /// </summary>
        public string Name { get; set; }
    }
}