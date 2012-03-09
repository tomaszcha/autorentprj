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
    /// Describes an auto category object
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Unique identifier of the auto category
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Category name
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// The need to make a deposit for the category
        /// </summary>
        public float Deposit { get; set; }
    }
}
