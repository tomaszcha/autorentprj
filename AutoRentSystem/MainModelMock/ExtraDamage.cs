using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainModelMock
{
    /// <summary>
    /// Describes extra damage object
    /// </summary>
    public class ExtraDamage
    {
        /// <summary>
        /// Unique identifier of the extra damage 
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Auto that is damaged
        /// </summary>
        public Auto Auto { get; set; }


        /// <summary>
        /// Name of the extra damage 
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Description of the extra damage 
        /// </summary>
        public string Description { get; set; }


        /// <summary>
        /// Value of the extra damage 
        /// </summary>
        public float Price { get; set; }


        /// <summary>
        /// Date of the extra damage 
        /// </summary>
        public DateTime DamageDate { get; set; }


        /// <summary>
        /// The date of of the extra damage fixing
        /// </summary>
        public DateTime FixDate { get; set; }
    }
}
