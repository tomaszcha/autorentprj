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
