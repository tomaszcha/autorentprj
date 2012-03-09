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
    /// Describes repair object
    /// </summary>
    public class Repair
    {
        /// <summary>
        /// Unique identifier of the repair
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Auto to repair
        /// </summary>
        public Auto Auto { get; set; }


        /// <summary>
        /// Technical service that provides repair
        /// </summary>
        public TechnicalService TechnicalService { get; set; }


        /// <summary>
        /// Start date of the repair
        /// </summary>
        public DateTime StartDate { get; set; }


        /// <summary>
        /// End date of the repair
        /// </summary>
        public DateTime EndDate { get; set; }


        /// <summary>
        /// Payment for the repair
        /// </summary>
        public float Payment { get; set; }


        /// <summary>
        /// Additional information about the repair
        /// </summary>
        public string Description { get; set; }
    }
}
