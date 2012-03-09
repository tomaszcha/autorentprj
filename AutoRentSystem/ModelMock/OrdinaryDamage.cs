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
    /// Describes ordinary damage object
    /// </summary>
    public class OrdinaryDamage
    {
        /// <summary>
        /// Unique identifier of the ordinary damage
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// The auto that is damaged
        /// </summary>
        public Auto Auto { get; set; }


        /// <summary>
        /// The damage with fixed price
        /// </summary>
        public Damage Damage { get; set; }


        /// <summary>
        /// The date of the damage
        /// </summary>
        public DateTime DamageDate { get; set; }


        /// <summary>
        /// The date of of the extra damage fixing
        /// </summary>
        public DateTime FixDate { get; set; }
    }
}
