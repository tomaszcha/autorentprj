using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainModelMock
{
    public class Insuarance
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public InsuaranceAgency InsuaranceAgency { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public float Payment { get; set; }
    }
}
