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
    public class Customers
    {
        public List<Customer> List;
        public Customers()
        {
            List = new List<Customer>
            {
                new Customer{ Id = Guid.NewGuid(), Name = "Name1", Type = "Type1", Address="Address1", 
                    Phone="(098)2587217", InsuranceNumber="12456477711", LicenceNumber="00153461234",
                    Passport="AK218748", BirthDay= new DateTime(1977, 11, 27) },
                new Customer{ Id = Guid.NewGuid(), Name = "Name2", Type = "Type2", Address="Address2", 
                    Phone="(050)1114578", InsuranceNumber="12456477711", LicenceNumber="21542268245",
                    Passport="AM251748", BirthDay= new DateTime(1985, 03, 16) },
                new Customer{ Id = Guid.NewGuid(), Name = "Name3", Type = "Type3", Address="Address3", 
                    Phone="(066)2547851", InsuranceNumber="12456477711", LicenceNumber="76546486124",
                    Passport="AM925846", BirthDay= new DateTime(1960, 05, 17) },
               new Customer{ Id = Guid.NewGuid(), Name = "Name4", Type = "Type4", Address="Address4", 
                    Phone="(098)3692514", InsuranceNumber="12456477711", LicenceNumber="55545646687",
                    Passport="AK117485", BirthDay= new DateTime(1980, 06, 11) }
            };                       
        }
    }
}
