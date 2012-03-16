using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SilverlightClientApp.Web.DataAccessLayer;

namespace InitDb
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoRentDbContext context = new AutoRentDbContext("AutoRentDb");
            context.Database.Initialize(true);
        }
    }
}
