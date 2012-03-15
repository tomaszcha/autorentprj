using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverlightClientApp.Web.Model
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