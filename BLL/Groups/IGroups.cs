using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace BLL.Groups
{
    public interface IGroups
    {
        #region Order

        List<Order> GetOrdersByType(int orderType);
        List<Order> GetOrdersByDepartment(int orderType, Guid departmentId);

        List<Order> GetrOdersByCustomerId(int orderType, Guid customerId);
        List<Order> GetOrdersByAutoNumber(int orderType, string autoNumber);        

        Order GetLastOrderByCustomerId(int orderType, Guid customerId);
        Order GetLastOrderByAutoNumber(int orderType, string autoNumber);
                
        void CreateOrder(Order order);
        void UpdateOrder(Order order);
        void RemoveOrder(int number);

        void ProlongateOrder(Order order);

        #endregion

        #region Auto

        List<Auto> GetAutosByModelName(string modelName);        
        List<string> GetAutoModelNames();

        void CreateAuto(Auto auto);
        void UpdateAuto(Auto auto);
        void RemoveAuto(string autoNumber);

        Auto GetAutoByNumber(string autoNumber);
        Auto GetAutoByOrderNumber(int orderNumber);

        #endregion
    }
}
