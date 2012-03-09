using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace ModelMock
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
