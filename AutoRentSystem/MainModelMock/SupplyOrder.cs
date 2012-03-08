using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainModelMock
{
    public class SupplyOrder
    {
        public int Id { get; set; }
        public Supplier Supplier { get; set; }
        public Model Model { get; set; }
        public float Price { get; set; }
        public short Quantity { get; set; }
    }
}
