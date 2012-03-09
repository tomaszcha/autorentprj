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
    /// Describes damage object
    /// </summary>
    public class Damage
    {
        /// <summary>
        /// Unique identifier of the damage
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Name of the damage
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// The value of the damage
        /// </summary>
        public float Price { get; set; }
    }
}
