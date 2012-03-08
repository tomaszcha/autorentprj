using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainModelMock
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
        public RentOrder RentOrder { get; set; }


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
