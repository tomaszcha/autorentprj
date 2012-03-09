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
    /// Describes supplier object
    /// </summary>
    public class Supplier
    {
        /// <summary>
        /// Unique identifier of the supplier
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// City where the supplier is located
        /// </summary>
        public City City { get; set; }


        /// <summary>
        /// Address within the city where supplier is located
        /// </summary>
        public string Address { get; set; }


        /// <summary>
        /// Contact phone of the supplier
        /// </summary>
        public string Phone { get; set; }
    }
}
