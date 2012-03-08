using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainModelMock
{
    public class EvacuationOrder
    {
        public int Id { get; set; }
        public RentOrder Order { get; set; }
        public City City { get; set; }
        public string Address { get; set; }
        public float Price { get; set; }
    }
}
