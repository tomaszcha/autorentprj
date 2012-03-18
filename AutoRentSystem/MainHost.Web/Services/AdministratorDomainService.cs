
namespace MainHost.Web.Services
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;
    using MainHost.Web.Models;


    [EnableClientAccess()]
    public class AdministratorDomainService : LinqToEntitiesDomainService<AutoRentEntities>
    {
        #region CRUD for Application

        /// <summary>
        /// Gets applications
        /// </summary>
        /// <returns>Applications</returns>
        [RequiresAuthentication]
        public IQueryable<Application> GetApplication()
        {
            return this.ObjectContext.Application;
        }


        /// <summary>
        /// Inserts application
        /// </summary>
        /// <param name="application">Application to insert</param>
        [RequiresAuthentication]
        public void InsertApplication(Application application)
        {
            if ((application.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(application, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Application.AddObject(application);
            }
        }


        /// <summary>
        /// Updates application
        /// </summary>
        /// <param name="currentApplication">Current application</param>
        [RequiresAuthentication]
        public void UpdateApplication(Application currentApplication)
        {
            this.ObjectContext.Application.AttachAsModified(currentApplication, this.ChangeSet.GetOriginal(currentApplication));
        }


        /// <summary>
        /// Deletes application
        /// </summary>
        /// <param name="application">Application to delete</param>
        [RequiresAuthentication]
        public void DeleteApplication(Application application)
        {
            if ((application.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(application, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Application.Attach(application);
                this.ObjectContext.Application.DeleteObject(application);
            }
        }

        #endregion

        #region CRUD for Auto

        /// <summary>
        /// Gets autos
        /// </summary>
        /// <returns>Autos</returns>
        [RequiresAuthentication]
        public IQueryable<Auto> GetAuto()
        {
            return this.ObjectContext.Auto;
        }


        /// <summary>
        /// Inserts auto
        /// </summary>
        /// <param name="auto">Auto to insert</param>
        [RequiresAuthentication]
        public void InsertAuto(Auto auto)
        {
            if ((auto.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(auto, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Auto.AddObject(auto);
            }
        }


        /// <summary>
        /// Updates auto
        /// </summary>
        /// <param name="currentAuto">Current auto</param>
        [RequiresAuthentication]
        public void UpdateAuto(Auto currentAuto)
        {
            this.ObjectContext.Auto.AttachAsModified(currentAuto, this.ChangeSet.GetOriginal(currentAuto));
        }


        /// <summary>
        /// Deletes auto
        /// </summary>
        /// <param name="auto">Auto to delete</param>
        [RequiresAuthentication]
        public void DeleteAuto(Auto auto)
        {
            if ((auto.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(auto, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Auto.Attach(auto);
                this.ObjectContext.Auto.DeleteObject(auto);
            }
        }

        #endregion 

        #region CRUD for Category

        /// <summary>
        /// Gets category
        /// </summary>
        /// <returns>Categories</returns>
        [RequiresAuthentication]
        public IQueryable<Category> GetCategory()
        {
            return this.ObjectContext.Category;
        }


        /// <summary>
        /// Insert category
        /// </summary>
        /// <param name="category">Category to insert</param>
        [RequiresAuthentication]
        public void InsertCategory(Category category)
        {
            if ((category.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(category, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Category.AddObject(category);
            }
        }


        /// <summary>
        /// Updates category
        /// </summary>
        /// <param name="currentCategory"></param>
        [RequiresAuthentication]
        public void UpdateCategory(Category currentCategory)
        {
            this.ObjectContext.Category.AttachAsModified(currentCategory, this.ChangeSet.GetOriginal(currentCategory));
        }


        /// <summary>
        /// Deletes category
        /// </summary>
        /// <param name="category">Category to delete</param>
        [RequiresAuthentication]
        public void DeleteCategory(Category category)
        {
            if ((category.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(category, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Category.Attach(category);
                this.ObjectContext.Category.DeleteObject(category);
            }
        }

        #endregion

        #region CRUD for ChargeOffOrder

        /// <summary>
        /// Gets charge-off orders
        /// </summary>
        /// <returns>Charge-off orders</returns>
        [RequiresAuthentication]
        public IQueryable<ChargeOffOrder> GetChargeOffOrder()
        {
            return this.ObjectContext.ChargeOffOrder;
        }


        /// <summary>
        /// Inserts charge-off order
        /// </summary>
        /// <param name="chargeOffOrder">Charge-off order to insert</param>
        [RequiresAuthentication]
        public void InsertChargeOffOrder(ChargeOffOrder chargeOffOrder)
        {
            if ((chargeOffOrder.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(chargeOffOrder, EntityState.Added);
            }
            else
            {
                this.ObjectContext.ChargeOffOrder.AddObject(chargeOffOrder);
            }
        }


        /// <summary>
        /// Updates charge-off order
        /// </summary>
        /// <param name="currentChargeOffOrder">Current charge-off order</param>
        [RequiresAuthentication]
        public void UpdateChargeOffOrder(ChargeOffOrder currentChargeOffOrder)
        {
            this.ObjectContext.ChargeOffOrder.AttachAsModified(currentChargeOffOrder, this.ChangeSet.GetOriginal(currentChargeOffOrder));
        }


        /// <summary>
        /// Deletes charge-off order
        /// </summary>
        /// <param name="chargeOffOrder">Charge-off order to delete</param>
        [RequiresAuthentication]
        public void DeleteChargeOffOrder(ChargeOffOrder chargeOffOrder)
        {
            if ((chargeOffOrder.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(chargeOffOrder, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.ChargeOffOrder.Attach(chargeOffOrder);
                this.ObjectContext.ChargeOffOrder.DeleteObject(chargeOffOrder);
            }
        }

        #endregion
        
        #region CRUD for City

        /// <summary>
        /// Gets cities
        /// </summary>
        /// <returns>Cities</returns>
        [RequiresAuthentication]
        public IQueryable<City> GetCity()
        {
            return this.ObjectContext.City;
        }


        [RequiresAuthentication]
        public void InsertCity(City city)
        {
            if ((city.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(city, EntityState.Added);
            }
            else
            {
                this.ObjectContext.City.AddObject(city);
            }
        }


        [RequiresAuthentication]
        public void UpdateCity(City currentCity)
        {
            this.ObjectContext.City.AttachAsModified(currentCity, this.ChangeSet.GetOriginal(currentCity));
        }


        [RequiresAuthentication]
        public void DeleteCity(City city)
        {
            if ((city.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(city, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.City.Attach(city);
                this.ObjectContext.City.DeleteObject(city);
            }
        }

        #endregion

        #region CRUD for Customer

        [RequiresAuthentication]
        public IQueryable<Customer> GetCustomer()
        {
            return this.ObjectContext.Customer;
        }

        [RequiresAuthentication]
        public void InsertCustomer(Customer customer)
        {
            if ((customer.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(customer, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Customer.AddObject(customer);
            }
        }

        [RequiresAuthentication]
        public void UpdateCustomer(Customer currentCustomer)
        {
            this.ObjectContext.Customer.AttachAsModified(currentCustomer, this.ChangeSet.GetOriginal(currentCustomer));
        }

        [RequiresAuthentication]
        public void DeleteCustomer(Customer customer)
        {
            if ((customer.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(customer, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Customer.Attach(customer);
                this.ObjectContext.Customer.DeleteObject(customer);
            }
        }

        #endregion

        #region CRUD for Damage

        [RequiresAuthentication]
        public IQueryable<Damage> GetDamage()
        {
            return this.ObjectContext.Damage;
        }

        [RequiresAuthentication]
        public void InsertDamage(Damage damage)
        {
            if ((damage.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(damage, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Damage.AddObject(damage);
            }
        }

        [RequiresAuthentication]
        public void UpdateDamage(Damage currentDamage)
        {
            this.ObjectContext.Damage.AttachAsModified(currentDamage, this.ChangeSet.GetOriginal(currentDamage));
        }

        [RequiresAuthentication]
        public void DeleteDamage(Damage damage)
        {
            if ((damage.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(damage, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Damage.Attach(damage);
                this.ObjectContext.Damage.DeleteObject(damage);
            }
        }

        #endregion

        #region CRUD for Department

        [RequiresAuthentication]     
        public IQueryable<Department> GetDepartment()
        {
            return this.ObjectContext.Department;
        }

        [RequiresAuthentication]
        public void InsertDepartment(Department department)
        {
            if ((department.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(department, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Department.AddObject(department);
            }
        }

        [RequiresAuthentication]
        public void UpdateDepartment(Department currentDepartment)
        {
            this.ObjectContext.Department.AttachAsModified(currentDepartment, this.ChangeSet.GetOriginal(currentDepartment));
        }

        [RequiresAuthentication]
        public void DeleteDepartment(Department department)
        {
            if ((department.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(department, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Department.Attach(department);
                this.ObjectContext.Department.DeleteObject(department);
            }
        }

        #endregion

        #region CRUD for Employee

        [RequiresAuthentication]
        public IQueryable<Employee> GetEmployee()
        {
            return this.ObjectContext.Employee;
        }

        [RequiresAuthentication]
        public void InsertEmployee(Employee employee)
        {
            if ((employee.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(employee, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Employee.AddObject(employee);
            }
        }

        [RequiresAuthentication]
        public void UpdateEmployee(Employee currentEmployee)
        {
            this.ObjectContext.Employee.AttachAsModified(currentEmployee, this.ChangeSet.GetOriginal(currentEmployee));
        }

        [RequiresAuthentication]
        public void DeleteEmployee(Employee employee)
        {
            if ((employee.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(employee, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Employee.Attach(employee);
                this.ObjectContext.Employee.DeleteObject(employee);
            }
        }

        #endregion

        #region CRUD for EvacuationOrder

        [RequiresAuthentication]
        public IQueryable<EvacuationOrder> GetEvacuationOrder()
        {
            return this.ObjectContext.EvacuationOrder;
        }

        [RequiresAuthentication]
        public void InsertEvacuationOrder(EvacuationOrder evacuationOrder)
        {
            if ((evacuationOrder.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(evacuationOrder, EntityState.Added);
            }
            else
            {
                this.ObjectContext.EvacuationOrder.AddObject(evacuationOrder);
            }
        }

        [RequiresAuthentication]
        public void UpdateEvacuationOrder(EvacuationOrder currentEvacuationOrder)
        {
            this.ObjectContext.EvacuationOrder.AttachAsModified(currentEvacuationOrder, this.ChangeSet.GetOriginal(currentEvacuationOrder));
        }

        [RequiresAuthentication]
        public void DeleteEvacuationOrder(EvacuationOrder evacuationOrder)
        {
            if ((evacuationOrder.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(evacuationOrder, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.EvacuationOrder.Attach(evacuationOrder);
                this.ObjectContext.EvacuationOrder.DeleteObject(evacuationOrder);
            }
        }

        #endregion

        #region CRUD for ExtraDamage

        [RequiresAuthentication]
        public IQueryable<ExtraDamage> GetExtraDamage()
        {
            return this.ObjectContext.ExtraDamage;
        }

        [RequiresAuthentication]
        public void InsertExtraDamage(ExtraDamage extraDamage)
        {
            if ((extraDamage.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(extraDamage, EntityState.Added);
            }
            else
            {
                this.ObjectContext.ExtraDamage.AddObject(extraDamage);
            }
        }

        [RequiresAuthentication]
        public void UpdateExtraDamage(ExtraDamage currentExtraDamage)
        {
            this.ObjectContext.ExtraDamage.AttachAsModified(currentExtraDamage, this.ChangeSet.GetOriginal(currentExtraDamage));
        }

        [RequiresAuthentication]
        public void DeleteExtraDamage(ExtraDamage extraDamage)
        {
            if ((extraDamage.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(extraDamage, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.ExtraDamage.Attach(extraDamage);
                this.ObjectContext.ExtraDamage.DeleteObject(extraDamage);
            }
        }

        #endregion

        #region CRUD for Insuarance

        [RequiresAuthentication]
        public IQueryable<Insuarance> GetInsuarance()
        {
            return this.ObjectContext.Insuarance;
        }

        [RequiresAuthentication]
        public void InsertInsuarance(Insuarance insuarance)
        {
            if ((insuarance.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(insuarance, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Insuarance.AddObject(insuarance);
            }
        }

        [RequiresAuthentication]
        public void UpdateInsuarance(Insuarance currentInsuarance)
        {
            this.ObjectContext.Insuarance.AttachAsModified(currentInsuarance, this.ChangeSet.GetOriginal(currentInsuarance));
        }

        [RequiresAuthentication]
        public void DeleteInsuarance(Insuarance insuarance)
        {
            if ((insuarance.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(insuarance, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Insuarance.Attach(insuarance);
                this.ObjectContext.Insuarance.DeleteObject(insuarance);
            }
        }

        #endregion

        #region CRUD for InsuaranceAgency

        [RequiresAuthentication]
        public IQueryable<InsuaranceAgency> GetInsuaranceAgency()
        {
            return this.ObjectContext.InsuaranceAgency;
        }

        [RequiresAuthentication]
        public void InsertInsuaranceAgency(InsuaranceAgency insuaranceAgency)
        {
            if ((insuaranceAgency.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(insuaranceAgency, EntityState.Added);
            }
            else
            {
                this.ObjectContext.InsuaranceAgency.AddObject(insuaranceAgency);
            }
        }

        [RequiresAuthentication]
        public void UpdateInsuaranceAgency(InsuaranceAgency currentInsuaranceAgency)
        {
            this.ObjectContext.InsuaranceAgency.AttachAsModified(currentInsuaranceAgency, this.ChangeSet.GetOriginal(currentInsuaranceAgency));
        }

        [RequiresAuthentication]
        public void DeleteInsuaranceAgency(InsuaranceAgency insuaranceAgency)
        {
            if ((insuaranceAgency.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(insuaranceAgency, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.InsuaranceAgency.Attach(insuaranceAgency);
                this.ObjectContext.InsuaranceAgency.DeleteObject(insuaranceAgency);
            }
        }

        #endregion

        #region CRUD for Make

        [RequiresAuthentication]
        public IQueryable<Make> GetMake()
        {
            return this.ObjectContext.Make;
        }

        [RequiresAuthentication]
        public void InsertMake(Make make)
        {
            if ((make.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(make, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Make.AddObject(make);
            }
        }

        [RequiresAuthentication]
        public void UpdateMake(Make currentMake)
        {
            this.ObjectContext.Make.AttachAsModified(currentMake, this.ChangeSet.GetOriginal(currentMake));
        }

        [RequiresAuthentication]
        public void DeleteMake(Make make)
        {
            if ((make.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(make, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Make.Attach(make);
                this.ObjectContext.Make.DeleteObject(make);
            }
        }

        #endregion

        #region CRUD forModel

        [RequiresAuthentication]
        public IQueryable<Model> GetModel()
        {
            return this.ObjectContext.Model;
        }

        [RequiresAuthentication]
        public void InsertModel(Model model)
        {
            if ((model.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(model, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Model.AddObject(model);
            }
        }

        [RequiresAuthentication]
        public void UpdateModel(Model currentModel)
        {
            this.ObjectContext.Model.AttachAsModified(currentModel, this.ChangeSet.GetOriginal(currentModel));
        }

        [RequiresAuthentication]
        public void DeleteModel(Model model)
        {
            if ((model.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(model, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Model.Attach(model);
                this.ObjectContext.Model.DeleteObject(model);
            }
        }

        #endregion

        #region CRUD for Order

        [RequiresAuthentication]
        public IQueryable<Order> GetOrder()
        {
            return this.ObjectContext.Order;
        }

        [RequiresAuthentication]
        public void InsertOrder(Order order)
        {
            if ((order.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(order, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Order.AddObject(order);
            }
        }

        [RequiresAuthentication]
        public void UpdateOrder(Order currentOrder)
        {
            this.ObjectContext.Order.AttachAsModified(currentOrder, this.ChangeSet.GetOriginal(currentOrder));
        }

        [RequiresAuthentication]
        public void DeleteOrder(Order order)
        {
            if ((order.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(order, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Order.Attach(order);
                this.ObjectContext.Order.DeleteObject(order);
            }
        }
        
        #endregion

        #region CRUD for OrdinaryDamage

        [RequiresAuthentication]
        public IQueryable<OrdinaryDamage> GetOrdinaryDamage()
        {
            return this.ObjectContext.OrdinaryDamage;
        }

        [RequiresAuthentication]
        public void InsertOrdinaryDamage(OrdinaryDamage ordinaryDamage)
        {
            if ((ordinaryDamage.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(ordinaryDamage, EntityState.Added);
            }
            else
            {
                this.ObjectContext.OrdinaryDamage.AddObject(ordinaryDamage);
            }
        }

        [RequiresAuthentication]
        public void UpdateOrdinaryDamage(OrdinaryDamage currentOrdinaryDamage)
        {
            this.ObjectContext.OrdinaryDamage.AttachAsModified(currentOrdinaryDamage, this.ChangeSet.GetOriginal(currentOrdinaryDamage));
        }

        [RequiresAuthentication]
        public void DeleteOrdinaryDamage(OrdinaryDamage ordinaryDamage)
        {
            if ((ordinaryDamage.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(ordinaryDamage, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.OrdinaryDamage.Attach(ordinaryDamage);
                this.ObjectContext.OrdinaryDamage.DeleteObject(ordinaryDamage);
            }
        }

        #endregion

        #region CRUD for PurchaseOrder

        [RequiresAuthentication]
        public IQueryable<PurchaseOrder> GetPurchaseOrder()
        {
            return this.ObjectContext.PurchaseOrder;
        }

        [RequiresAuthentication]
        public void InsertPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            if ((purchaseOrder.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(purchaseOrder, EntityState.Added);
            }
            else
            {
                this.ObjectContext.PurchaseOrder.AddObject(purchaseOrder);
            }
        }

        [RequiresAuthentication]
        public void UpdatePurchaseOrder(PurchaseOrder currentPurchaseOrder)
        {
            this.ObjectContext.PurchaseOrder.AttachAsModified(currentPurchaseOrder, this.ChangeSet.GetOriginal(currentPurchaseOrder));
        }

        [RequiresAuthentication]
        public void DeletePurchaseOrder(PurchaseOrder purchaseOrder)
        {
            if ((purchaseOrder.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(purchaseOrder, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.PurchaseOrder.Attach(purchaseOrder);
                this.ObjectContext.PurchaseOrder.DeleteObject(purchaseOrder);
            }
        }

        #endregion

        #region CRUD for Purchaser

        [RequiresAuthentication]
        public IQueryable<Purchaser> GetPurchaser()
        {
            return this.ObjectContext.Purchaser;
        }

        [RequiresAuthentication]
        public void InsertPurchaser(Purchaser purchaser)
        {
            if ((purchaser.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(purchaser, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Purchaser.AddObject(purchaser);
            }
        }

        [RequiresAuthentication]
        public void UpdatePurchaser(Purchaser currentPurchaser)
        {
            this.ObjectContext.Purchaser.AttachAsModified(currentPurchaser, this.ChangeSet.GetOriginal(currentPurchaser));
        }

        [RequiresAuthentication]
        public void DeletePurchaser(Purchaser purchaser)
        {
            if ((purchaser.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(purchaser, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Purchaser.Attach(purchaser);
                this.ObjectContext.Purchaser.DeleteObject(purchaser);
            }
        }

        #endregion

        #region CRUD for Repair

        [RequiresAuthentication]
        public IQueryable<Repair> GetRepair()
        {
            return this.ObjectContext.Repair;
        }

        [RequiresAuthentication]
        public void InsertRepair(Repair repair)
        {
            if ((repair.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(repair, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Repair.AddObject(repair);
            }
        }

        [RequiresAuthentication]
        public void UpdateRepair(Repair currentRepair)
        {
            this.ObjectContext.Repair.AttachAsModified(currentRepair, this.ChangeSet.GetOriginal(currentRepair));
        }

        [RequiresAuthentication]
        public void DeleteRepair(Repair repair)
        {
            if ((repair.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(repair, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Repair.Attach(repair);
                this.ObjectContext.Repair.DeleteObject(repair);
            }
        }
        #endregion

        #region CRUD for Supplier

        [RequiresAuthentication]
        public IQueryable<Supplier> GetSupplier()
        {
            return this.ObjectContext.Supplier;
        }

        [RequiresAuthentication]
        public void InsertSupplier(Supplier supplier)
        {
            if ((supplier.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(supplier, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Supplier.AddObject(supplier);
            }
        }

        [RequiresAuthentication]
        public void UpdateSupplier(Supplier currentSupplier)
        {
            this.ObjectContext.Supplier.AttachAsModified(currentSupplier, this.ChangeSet.GetOriginal(currentSupplier));
        }

        [RequiresAuthentication]
        public void DeleteSupplier(Supplier supplier)
        {
            if ((supplier.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(supplier, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Supplier.Attach(supplier);
                this.ObjectContext.Supplier.DeleteObject(supplier);
            }
        }

        #endregion

        #region CRUD for SupplyOrder

        [RequiresAuthentication]
        public IQueryable<SupplyOrder> GetSupplyOrder()
        {
            return this.ObjectContext.SupplyOrder;
        }

        [RequiresAuthentication]
        public void InsertSupplyOrder(SupplyOrder supplyOrder)
        {
            if ((supplyOrder.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(supplyOrder, EntityState.Added);
            }
            else
            {
                this.ObjectContext.SupplyOrder.AddObject(supplyOrder);
            }
        }

        [RequiresAuthentication]
        public void UpdateSupplyOrder(SupplyOrder currentSupplyOrder)
        {
            this.ObjectContext.SupplyOrder.AttachAsModified(currentSupplyOrder, this.ChangeSet.GetOriginal(currentSupplyOrder));
        }

        [RequiresAuthentication]
        public void DeleteSupplyOrder(SupplyOrder supplyOrder)
        {
            if ((supplyOrder.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(supplyOrder, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.SupplyOrder.Attach(supplyOrder);
                this.ObjectContext.SupplyOrder.DeleteObject(supplyOrder);
            }
        }

        #endregion

        #region CRUD for TechnicalService

        [RequiresAuthentication]
        public IQueryable<TechnicalService> GetTechnicalService()
        {
            return this.ObjectContext.TechnicalService;
        }

        [RequiresAuthentication]
        public void InsertTechnicalService(TechnicalService technicalService)
        {
            if ((technicalService.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(technicalService, EntityState.Added);
            }
            else
            {
                this.ObjectContext.TechnicalService.AddObject(technicalService);
            }
        }

        [RequiresAuthentication]
        public void UpdateTechnicalService(TechnicalService currentTechnicalService)
        {
            this.ObjectContext.TechnicalService.AttachAsModified(currentTechnicalService, this.ChangeSet.GetOriginal(currentTechnicalService));
        }

        [RequiresAuthentication]
        public void DeleteTechnicalService(TechnicalService technicalService)
        {
            if ((technicalService.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(technicalService, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.TechnicalService.Attach(technicalService);
                this.ObjectContext.TechnicalService.DeleteObject(technicalService);
            }
        }

        #endregion
    }
}


