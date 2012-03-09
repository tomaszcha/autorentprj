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
    /// Describes evacuation order object 
    /// </summary>
    public class EvacuationOrder
    {
        /// <summary>
        /// Unique identifier of the evacuation order
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Rent order of the auto that needs the evacuation
        /// </summary>
        public Order Order { get; set; }


        /// <summary>
        /// City where the broken auto is  
        /// </summary>
        public City City { get; set; }


        /// <summary>
        /// Address within the city where the broken auto is 
        /// </summary>
        public string Address { get; set; }


        /// <summary>
        /// Value of the evacuation
        /// </summary>
        public float Value { get; set; }
    }
}
