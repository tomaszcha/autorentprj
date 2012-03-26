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
    }
}
