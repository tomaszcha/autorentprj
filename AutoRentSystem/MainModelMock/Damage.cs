using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainModelMock
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
