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
    /// Describes technical service object
    /// </summary>
    public class TechnicalService
    {
        /// <summary>
        /// Unique identifier of the technical service
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Name of the technical service
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// City where the technical service is located
        /// </summary>
        public City City { get; set; }


        /// <summary>
        /// Address of the technical service within the city
        /// </summary>
        public string Address { get; set; }


        /// <summary>
        /// Technical service contact phone number
        /// </summary>
        public string Phone { get; set; }
    }
}
