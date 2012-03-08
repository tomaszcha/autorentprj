using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainModelMock
{
    /// <summary>
    /// Describes employee object
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Unique identifier of the employee
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Department where employee works
        /// </summary>
        public Department Department { get; set; }


        /// <summary>
        /// First name of the employee
        /// </summary>
        public string FirstName { get; set; }


        /// <summary>
        /// Last name of the employee
        /// </summary>
        public string LastName { get; set; }


        /// <summary>
        /// Birthday of the employee
        /// </summary>
        public DateTime Birthday { get; set; }


        /// <summary>
        /// Identification code of the employee
        /// </summary>
        public string IdentCode { get; set; }


        /// <summary>
        /// Passport data of the employee
        /// </summary>
        public string Passport { get; set; }


        /// <summary>
        /// City where employee lives
        /// </summary>
        public City City { get; set; }


        /// <summary>
        /// Address of the employee within the city where he/she lives
        /// </summary>
        public string Address { get; set; }


        /// <summary>
        /// Contact phone number of the employee
        /// </summary>
        public string Phone { get; set; }


        /// <summary>
        /// Position of the employee
        /// </summary>
        public string Position { get; set; }


        /// <summary>
        /// Hire date of of the employee
        /// </summary>
        public DateTime HireDate { get; set; }


        /// <summary>
        /// Fire date of the employee
        /// </summary>
        public DateTime FireDate { get; set; }
    }
}
