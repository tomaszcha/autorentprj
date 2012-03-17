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
    /// Describes purchaser object
    /// </summary>
    public class Purchaser
    {
        /// <summary>
        /// Unique identifier of the purchaser
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Name of the purchaser
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// City where the purchaser is located
        /// </summary>
        public City City { get; set; }


        /// <summary>
        /// Address within the city where the purchaser is located
        /// </summary>
        public string Address { get; set; }


        /// <summary>
        /// Contact phone number of the purchaser
        /// </summary>
        public string Phone { get; set; }
    }
}
