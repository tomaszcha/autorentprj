using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainModelMock
{
    public class Employee
    {
        public int Id { get; set; }
        public Department Department { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string IdentCode { get; set; }
        public string Passport { get; set; }
        public City City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Position { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime FireDate { get; set; }
    }
}
