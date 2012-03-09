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
