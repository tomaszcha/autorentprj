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
    /// Describes insuarance object
    /// </summary>
    public class Insuarance
    {
        /// <summary>
        /// Unique identifier of the insuarance
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Insuarance number
        /// </summary>
        public string Number { get; set; }


        /// <summary>
        /// Insuarance agency that issued the insuarance
        /// </summary>
        public InsuaranceAgency InsuaranceAgency { get; set; }


        /// <summary>
        /// Expiration date of the insuarance
        /// </summary>
        public DateTime ExpirationDate { get; set; }


        /// <summary>
        /// Regular insuarance payment
        /// </summary>
        public float Payment { get; set; }
    }
}
