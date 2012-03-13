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
    /// Describes model object of the auto
    /// </summary>
    public class Model
    {
        /// <summary>
        /// Unique identifier of the auto model
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Name of the auto model
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Make of the auto model
        /// </summary>
        public Make Make { get; set; }


        /// <summary>
        /// Number of seats of the auto model
        /// </summary>
        public int Seats { get; set; }


        /// <summary>
        /// Engine capacity of the auto
        /// </summary>
        public string EngineCapacity { get; set; }


        /// <summary>
        /// Photo of the auto model
        /// </summary>
        public byte[] Photo { get; set; }


        /// <summary>
        /// Rental rate of one hour 
        /// </summary>
        public float HourRate { get; set; }


        /// <summary>
        /// Rental rate of one day
        /// </summary>
        public float DayRate { get; set; }


        /// <summary>
        /// Deposit for the rental auto
        /// </summary>
        public float Deposit { get; set; }
    }
}
