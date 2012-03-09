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
