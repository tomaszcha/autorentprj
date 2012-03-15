using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SilverlightClientApp.Web.DataAccessLayer;

namespace InitDbApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoRentDbContext context = new AutoRentDbContext();
            context.Database.Initialize(true);
        }
    }
}
