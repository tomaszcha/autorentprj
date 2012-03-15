using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverlightClientApp.Web.DbModel
{
    /// <summary>
    /// Describes make of the auto 
    /// </summary>
    public class Make
    {
        /// <summary>
        /// Unique identifier of the make
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Name of the make 
        /// </summary>
        public string Name { get; set; }
    }
}