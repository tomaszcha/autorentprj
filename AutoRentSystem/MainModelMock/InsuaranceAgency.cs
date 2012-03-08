using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainModelMock
{
    public class InsuaranceAgency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public City City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
