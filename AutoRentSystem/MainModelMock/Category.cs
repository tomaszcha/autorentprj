using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainModelMock
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Deposit { get; set; }
        public float MinPrice { get; set; }
        public float MaxPrice { get; set; }
    }
}
