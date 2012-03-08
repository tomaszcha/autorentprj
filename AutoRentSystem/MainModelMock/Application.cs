using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainModelMock
{
    public class Application
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreationDate { get; set; }
        public Model Model { get; set; }
        public string Preference { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Department PickupDepartment { get; set; }
        public Department ReturnDepartment { get; set; }
        public string Status { get; set; }
        public string Email { get; set; }
    }
}
