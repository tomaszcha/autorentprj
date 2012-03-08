using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainModelMock
{
    public class OrdinaryDamage
    {
        public int Id { get; set; }
        public Auto Auto { get; set; }
        public Damage Damage { get; set; }
        public DateTime DamageDate { get; set; }
        public DateTime FixDate { get; set; }
    }
}
