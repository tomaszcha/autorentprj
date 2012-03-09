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
    /// Describes city object
    /// </summary>
    public class City
    {
        /// <summary>
        /// Unique identifier of the city
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// City name
        /// </summary>
        public string Name { get; set; }
    }
}
