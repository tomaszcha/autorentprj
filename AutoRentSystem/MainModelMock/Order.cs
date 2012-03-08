using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainModelMock
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public Auto Auto { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Department PickupDepartment { get; set; }
        public Department ReturnDepartment { get; set; }
        public string Status { get; set; }
        public string RentalType { get; set; }
        
    }
}
