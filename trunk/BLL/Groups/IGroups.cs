using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace BLL.Groups
{
    public class IGroups
    {
        public List<Order> GetOrdersByType(int orderType);
        public List<Order> GetOrdersByDepartment(int orderType, Guid departmentId);

        public List<Order> GetrOdersByCustomerId(int orderType, Guid customerId);
        public List<Order> GetOrdersByAutoNumber(int orderType, string autoNumber);        

        public Order GetLastOrderByCustomerId(int orderType, Guid customerId);
        public Order GetLastOrderByAutoNumber(int orderType, string autoNumber);
                
        public void CreateOrder(Order order);
        public void UpdateOrder(Order order);
        public void RemoveOrder(int number);
    }
}
