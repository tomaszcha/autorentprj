using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverlightClientApp.Web.Model
{
    /// <summary>
    /// Describes an auto category object
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Unique identifier of the auto category
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Category name
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// The need to make a deposit for the category
        /// </summary>
        public float Deposit { get; set; }
    }
}