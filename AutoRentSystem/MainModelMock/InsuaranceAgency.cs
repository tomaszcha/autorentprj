using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainModelMock
{
    /// <summary>
    /// Describes insuarance agency object
    /// </summary>
    public class InsuaranceAgency
    {
        /// <summary>
        /// Unique identifier of the insuarance agency
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Name of the insuarance agency
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// City where the insuarance agency is located
        /// </summary>
        public City City { get; set; }


        /// <summary>
        /// Address of the insuarance agency within the city
        /// </summary>
        public string Address { get; set; }


        /// <summary>
        /// Contact phone number of the insuarance agency
        /// </summary>
        public string Phone { get; set; }
    }
}
