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
    /// Describes make of the auto 
    /// </summary>
    public class Make
    {
        /// <summary>
        /// Unique identifier of the make
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Name of the make 
        /// </summary>
        public string Name { get; set; }
    }
}
