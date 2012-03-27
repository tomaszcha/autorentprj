using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Model;
using DAL.Administration;

namespace DALTests
{
    [TestFixture]
    class HRAdminTest
    {        
        #region Data

        private List<Employee> emploies;
        private List<Members> members;

        
        #endregion Data

        [Test]
        public void CreateEmployeProfileWithRegistration()
        {
            HRAdmin admin = new HRAdmin();
            Employee empl = new Employee
            {
                Address = "street. Lenin, 116a",
                BirthDay = new DateTime(1979, 01, 15),
                FirstName = "Petr",
                LastName = "Perviy",
                Phone = "(065)6035282",
                HireDate = DateTime.Now
            };
            Guid id = admin.CreateEmployeProfile(empl);
            admin.Registrate(new Members { ERecord = id, Created = DateTime.Now, Email = "petr@gmail.com", Login = "Petr", Password = "Petr" });
        }

        [Test]
        public void CreateCustomerProfileWithRegistration()
        {
            HRAdmin admin = new HRAdmin();
            Customer cust = new Customer
            {
                Address = "street. Nizhnegorsky, 51a",
                BirthDay = new DateTime(1988, 05, 02),
                Name = "Lev Petrovich",
                Phone = "(065)5991945",
                Type = "Client"
            };
            Guid id = admin.CreateCustomerProfile(cust);
            admin.Registrate(new Members { CRecord = id, Created = DateTime.Now, Email = "lev@gmail.com", Login = "Lev", Password = "Lev" });
        }

        /*
        [Test]
        public void RemoveCustomerProfileWithRegistration()
        {
            HRAdmin admin = new HRAdmin();
            admin.RemoveCustomerProfile(new Guid("660A2FBE-1EBB-4C3B-9A01-852F1ACDC781"));           
        }
         
        [Test]
        public void RemoveEmployeeProfileWithRegistration()
        {
            HRAdmin admin = new HRAdmin();
            admin.RemoveEmployeeProfile(new Guid("C4F1B6EB-C406-4AB9-B014-E7743E774722"));           
        }
        */
    }
}
