using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainModelMock
{
    public class ChargeOffOrder
    {
        public int Id { get; set; }
        public Auto Auto { get; set; }
        public Employee Mechanic { get; set; }
        public Employee Manager { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
    }
}
