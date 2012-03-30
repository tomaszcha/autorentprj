using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace BLL.Groups
{
    public interface IGroups
    {
        List<Order> GetOrdersByType(int orderType);
        List<Order> GetOrdersByDepartment(int orderType, Guid departmentId);

        List<Order> GetrOdersByCustomerId(int orderType, Guid customerId);
        List<Order> GetOrdersByAutoNumber(int orderType, string autoNumber);        

        Order GetLastOrderByCustomerId(int orderType, Guid customerId);
        Order GetLastOrderByAutoNumber(int orderType, string autoNumber);
                
        void CreateOrder(Order order);
        void UpdateOrder(Order order);
        void RemoveOrder(int number);


    }
}
