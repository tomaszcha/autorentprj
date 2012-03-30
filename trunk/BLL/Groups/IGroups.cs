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

        #region  DamageClass
        
        List<DamageClass> GetDamageClasss();

        void CreateDamageClass(DamageClass damageClass);
        void UpdateDamageClass(DamageClass damageClass);
        void RemoveDamageClass(int clss);

        #endregion

        #region Damages

        List<Damages> GetDamages();        
        List<Damages> GetDamagesByRevision(int id);
        Damages GetDamagesById(int revisionId);

        void CreateDamages(Damages damages);
        void UpdateDamages(Damages damages);
        void RemoveDamages(int id);
       
        #endregion

        #region Department
        
        List<Department> GetDepartments();
        Department GetDepartmentById(Guid id);

        Guid CreateDepartment(Department department);
        void UpdateDepartment(Department department);
        void RemoveDepartment(Guid guid);

        #endregion
    }
}
