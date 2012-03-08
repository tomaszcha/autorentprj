using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainModelMock
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public Purchaser Purchaser { get; set; }
        public Auto Auto { get; set; }
        public float Price { get; set; }
    }
}
