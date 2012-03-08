using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainModelMock
{
    /// <summary>
    /// Describes department object
    /// </summary>
    public class Department
    {
        /// <summary>
        /// Unique identifier of the department
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// City where the department is located
        /// </summary>
        public City City { get; set; }


        /// <summary>
        /// Address of the department within the city 
        /// </summary>
        public string Address { get; set; }


        /// <summary>
        /// Contact phone number of the department
        /// </summary>
        public string Phone { get; set; }
    }
}
