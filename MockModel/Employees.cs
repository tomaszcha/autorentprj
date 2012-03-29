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
    public class Employees
    {
        public List<Employee> List;
        public Employees()
        {
            List = new List<Employee>
            {
                new Employee{Id=Guid.NewGuid(), Address="Address1", BirthDay= new DateTime(1956, 12, 06),
                FirstName="Name1", LastName="LastName1", HireDate=DateTime.Now, InsuaranceNumber="2145411211",
                LicenceNumber="54655", Phone="(063)5463217", Position="Manager"},
                new Employee{Id=Guid.NewGuid(), Address="Address2", BirthDay= new DateTime(1956, 12, 06),
                FirstName="Name2", LastName="LastName2", HireDate=DateTime.Now, InsuaranceNumber="554635451",
                LicenceNumber="54655", Phone="(063)5605544", Position="Mechanic"},
                new Employee{Id=Guid.NewGuid(), Address="Address3", BirthDay= new DateTime(1956, 12, 06),
                FirstName="Name3", LastName="LastName3", HireDate=DateTime.Now, InsuaranceNumber="2145411211",
                LicenceNumber="54655", Phone="(063)5632178", Position="Manager"}
            };
        }
    }
}
