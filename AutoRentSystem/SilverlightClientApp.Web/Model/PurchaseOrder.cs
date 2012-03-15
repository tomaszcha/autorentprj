using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverlightClientApp.Web.Model
{
    /// <summary>
    /// Describes purchase order object
    /// </summary>
    public class PurchaseOrder
    {
        /// <summary>
        /// Unique identifier of the purchase order
        /// </summary> 
        public int Id { get; set; }


        /// <summary>
        /// The purchaser of the auto
        /// </summary>
        public Purchaser Purchaser { get; set; }


        /// <summary>
        /// The auto to charge off by sale
        /// </summary>
        public Auto Auto { get; set; }


        /// <summary>
        /// Price of the auto to purchase
        /// </summary>
        public float Price { get; set; }
    }
}