using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverlightClientApp.Web.DbModel
{
    /// <summary>
    /// Describes supply order object
    /// </summary>
    public class SupplyOrder
    {
        /// <summary>
        /// Unique identifier of the supply order
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Supplier of the autos
        /// </summary>
        public Supplier Supplier { get; set; }


        /// <summary>
        /// Model of the supplied autos
        /// </summary>
        public Model Model { get; set; }


        /// <summary>
        /// Price for the one auto
        /// </summary>
        public float Price { get; set; }


        /// <summary>
        /// Quantity of the supplied autos
        /// </summary>
        public short Quantity { get; set; }
    }
}