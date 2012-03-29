using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace MockModel
{
    public class Orders
    {
        public List<Order> List;
        public Orders()
        {
            List = new List<Order>
            {
                new Order{ Number = 1, AutoNumber = "AA1112DA", CustomerId = new Guid(), ManagerId = new Guid(), 
                    CreationDate = new DateTime(2012, 03, 11), ExpiredDate = new DateTime(2012, 03, 15),
                    DepartmentId = new Guid(), Type = 1, Status = 2 },
               new Order{ Number = 2, AutoNumber = "AA5547DA", CustomerId = new Guid(), ManagerId = new Guid(), 
                    CreationDate = new DateTime(2012, 03, 14), ExpiredDate = new DateTime(2012, 03, 17),
                    DepartmentId = new Guid(), Type = 1, Status = 2 },
               new Order{ Number = 3, AutoNumber = "AA3347DA", CustomerId = new Guid(), ManagerId = new Guid(), 
                    CreationDate = new DateTime(2012, 03, 15), ExpiredDate = new DateTime(2012, 03, 19),
                    DepartmentId = new Guid(), Type = 1, Status = 2 }
            };
        }    
    }
}
