using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainModelMock
{
    public class Repair
    {
        public int Id { get; set; }
        public Auto Auto { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public float Payment { get; set; }
        public TechnicalService TechnicalService { get; set; }
    }
}
