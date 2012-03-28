﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Model;
using DAL.Accessors;

namespace DALTests
{
    [TestFixture]
    public class DepartmentAccessorTest
    {
        
        [Test]
        public void CreateDepartmentTest()
        {
            DepartmentAccessor deptAccessor = new DepartmentAccessor();
            Department department = new Department
            {
                CityCode = 10,
                Name = "LvDept",
                Addresse = "Straus Str., 12",                
                Phone = "(065)6035282"
            };
            Guid id = deptAccessor.CreateDepartment(department);
        }
                
        [Test]
        public void UpdateDepartmentTest()
        {
            DepartmentAccessor deptAccessor = new DepartmentAccessor();
            Department department = new Department
            {                
                CityCode = 20,
                Name = "KievDept",
                Addresse = "Central st., 74",
                Phone = "(050)2536789"
            };
            department.Id = deptAccessor.CreateDepartment(department);
            department.Phone = "(098)1212111";
            deptAccessor.UpdateDepartment(department);
        }

        [Test]
        public void GetDepartmentsTest()
        {
            DepartmentAccessor deptAccessor = new DepartmentAccessor();
            List<Department> departments = deptAccessor.GetDepartments();
            foreach (Department d in departments)
            {
                Console.WriteLine("ID:{0}, Name:{1}, CityCode:{2}, Addresse:{3}, Phone{4}", 
                    d.Id, d.Name, d.CityCode, d.Addresse, d.Phone);
            }
        }

        /*
        [Test]
        public void RemoveCustomerProfileWithRegistration()
        {
            DepartmentAccessor deptAccessor = new DepartmentAccessor();
            deptAccessor.RemoveDepartment(new Guid("2F56BC3B-D25B-4353-A008-381688ED4C4C"));           
        }*/
    }
}
