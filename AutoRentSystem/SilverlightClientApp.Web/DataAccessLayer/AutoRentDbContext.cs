using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SilverlightClientApp.Web.DbModel;

namespace SilverlightClientApp.Web.DataAccessLayer
{
    public class AutoRentDbContext : DbContext
    {
        public AutoRentDbContext() { }

        public AutoRentDbContext(string databaseName) : base(databaseName) { }

        public DbSet<Application> Applications { get; set; }

        public DbSet<Auto> Autos { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ChargeOffOrder> ChargeOffOrders { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Damage> Damages { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<EvacuationOrder> EvacuationOrders { get; set; }

        public DbSet<ExtraDamage> ExtraDamages { get; set; }

        public DbSet<Insuarance> Insuarances { get; set; }

        public DbSet<InsuaranceAgency> InsuaranceAgencies { get; set; }

        public DbSet<Make> Makes { get; set; }

        public DbSet<Model> Models { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrdinaryDamage> OrdinaryDamages { get; set; }

        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }

        public DbSet<Purchaser> Purchasers { get; set; }

        public DbSet<Repair> Repairs { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<SupplyOrder> SupplyOrders { get; set; }

        public DbSet<TechnicalService> TechnicalServices { get; set; }
    }
}