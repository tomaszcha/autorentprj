﻿
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


    // Реализует логику приложения с использованием контекста AutoRentEntities.
    // TODO: добавьте свою прикладную логику в эти или другие методы.
    // TODO: включите проверку подлинности (Windows/ASP.NET Forms) и раскомментируйте следующие строки, чтобы запретить анонимный доступ
    // Кроме того, рассмотрите возможность добавления ролей для соответствующего ограничения доступа.
    [RequiresAuthentication]
    [EnableClientAccess()]
    public class DomainService1 : LinqToEntitiesDomainService<AutoRentEntities>
    {

        // TODO:
        // рассмотрите возможность сокращения результатов метода запроса.  Если необходим дополнительный ввод,
        // то в этот метод можно добавить параметры или создать дополнительные методы выполнения запроса с другими именами.
        // Для поддержки разбиения на страницы добавьте упорядочение в запрос "Application".
        [Query(IsDefault = true)]
        public IQueryable<Application> GetApplication()
        {
            return this.ObjectContext.Application;
        }

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

        public void UpdateApplication(Application currentApplication)
        {
            this.ObjectContext.Application.AttachAsModified(currentApplication, this.ChangeSet.GetOriginal(currentApplication));
        }

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

        // TODO:
        // рассмотрите возможность сокращения результатов метода запроса.  Если необходим дополнительный ввод,
        // то в этот метод можно добавить параметры или создать дополнительные методы выполнения запроса с другими именами.
        // Для поддержки разбиения на страницы добавьте упорядочение в запрос "Auto".
        [Query(IsDefault = true)]
        public IQueryable<Auto> GetAuto()
        {
            return this.ObjectContext.Auto;
        }

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

        public void UpdateAuto(Auto currentAuto)
        {
            this.ObjectContext.Auto.AttachAsModified(currentAuto, this.ChangeSet.GetOriginal(currentAuto));
        }

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

        // TODO:
        // рассмотрите возможность сокращения результатов метода запроса.  Если необходим дополнительный ввод,
        // то в этот метод можно добавить параметры или создать дополнительные методы выполнения запроса с другими именами.
        // Для поддержки разбиения на страницы добавьте упорядочение в запрос "Category".
        [Query(IsDefault = true)]
        public IQueryable<Category> GetCategory()
        {
            return this.ObjectContext.Category;
        }

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

        public void UpdateCategory(Category currentCategory)
        {
            this.ObjectContext.Category.AttachAsModified(currentCategory, this.ChangeSet.GetOriginal(currentCategory));
        }

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

        // TODO:
        // рассмотрите возможность сокращения результатов метода запроса.  Если необходим дополнительный ввод,
        // то в этот метод можно добавить параметры или создать дополнительные методы выполнения запроса с другими именами.
        // Для поддержки разбиения на страницы добавьте упорядочение в запрос "ChargeOffOrder".
        [Query(IsDefault = true)]
        public IQueryable<ChargeOffOrder> GetChargeOffOrder()
        {
            return this.ObjectContext.ChargeOffOrder;
        }

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

        public void UpdateChargeOffOrder(ChargeOffOrder currentChargeOffOrder)
        {
            this.ObjectContext.ChargeOffOrder.AttachAsModified(currentChargeOffOrder, this.ChangeSet.GetOriginal(currentChargeOffOrder));
        }

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

        // TODO:
        // рассмотрите возможность сокращения результатов метода запроса.  Если необходим дополнительный ввод,
        // то в этот метод можно добавить параметры или создать дополнительные методы выполнения запроса с другими именами.
        // Для поддержки разбиения на страницы добавьте упорядочение в запрос "City".
        [Query(IsDefault = true)]
        public IQueryable<City> GetCity()
        {
            return this.ObjectContext.City;
        }

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

        public void UpdateCity(City currentCity)
        {
            this.ObjectContext.City.AttachAsModified(currentCity, this.ChangeSet.GetOriginal(currentCity));
        }

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

        // TODO:
        // рассмотрите возможность сокращения результатов метода запроса.  Если необходим дополнительный ввод,
        // то в этот метод можно добавить параметры или создать дополнительные методы выполнения запроса с другими именами.
        // Для поддержки разбиения на страницы добавьте упорядочение в запрос "Customer".
        [Query(IsDefault = true)]
        public IQueryable<Customer> GetCustomer()
        {
            return this.ObjectContext.Customer;
        }

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

        public void UpdateCustomer(Customer currentCustomer)
        {
            this.ObjectContext.Customer.AttachAsModified(currentCustomer, this.ChangeSet.GetOriginal(currentCustomer));
        }

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

        // TODO:
        // рассмотрите возможность сокращения результатов метода запроса.  Если необходим дополнительный ввод,
        // то в этот метод можно добавить параметры или создать дополнительные методы выполнения запроса с другими именами.
        // Для поддержки разбиения на страницы добавьте упорядочение в запрос "Damage".
        [Query(IsDefault = true)]
        public IQueryable<Damage> GetDamage()
        {
            return this.ObjectContext.Damage;
        }

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

        public void UpdateDamage(Damage currentDamage)
        {
            this.ObjectContext.Damage.AttachAsModified(currentDamage, this.ChangeSet.GetOriginal(currentDamage));
        }

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

        // TODO:
        // рассмотрите возможность сокращения результатов метода запроса.  Если необходим дополнительный ввод,
        // то в этот метод можно добавить параметры или создать дополнительные методы выполнения запроса с другими именами.
        // Для поддержки разбиения на страницы добавьте упорядочение в запрос "Department".
        [Query(IsDefault = true)]
        public IQueryable<Department> GetDepartment()
        {
            return this.ObjectContext.Department;
        }

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

        public void UpdateDepartment(Department currentDepartment)
        {
            this.ObjectContext.Department.AttachAsModified(currentDepartment, this.ChangeSet.GetOriginal(currentDepartment));
        }

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

        // TODO:
        // рассмотрите возможность сокращения результатов метода запроса.  Если необходим дополнительный ввод,
        // то в этот метод можно добавить параметры или создать дополнительные методы выполнения запроса с другими именами.
        // Для поддержки разбиения на страницы добавьте упорядочение в запрос "Employee".
        [Query(IsDefault = true)]
        public IQueryable<Employee> GetEmployee()
        {
            return this.ObjectContext.Employee;
        }

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

        public void UpdateEmployee(Employee currentEmployee)
        {
            this.ObjectContext.Employee.AttachAsModified(currentEmployee, this.ChangeSet.GetOriginal(currentEmployee));
        }

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

        // TODO:
        // рассмотрите возможность сокращения результатов метода запроса.  Если необходим дополнительный ввод,
        // то в этот метод можно добавить параметры или создать дополнительные методы выполнения запроса с другими именами.
        // Для поддержки разбиения на страницы добавьте упорядочение в запрос "EvacuationOrder".
        [Query(IsDefault = true)]
        public IQueryable<EvacuationOrder> GetEvacuationOrder()
        {
            return this.ObjectContext.EvacuationOrder;
        }

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

        public void UpdateEvacuationOrder(EvacuationOrder currentEvacuationOrder)
        {
            this.ObjectContext.EvacuationOrder.AttachAsModified(currentEvacuationOrder, this.ChangeSet.GetOriginal(currentEvacuationOrder));
        }

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

        // TODO:
        // рассмотрите возможность сокращения результатов метода запроса.  Если необходим дополнительный ввод,
        // то в этот метод можно добавить параметры или создать дополнительные методы выполнения запроса с другими именами.
        // Для поддержки разбиения на страницы добавьте упорядочение в запрос "ExtraDamage".
        [Query(IsDefault = true)]
        public IQueryable<ExtraDamage> GetExtraDamage()
        {
            return this.ObjectContext.ExtraDamage;
        }

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

        public void UpdateExtraDamage(ExtraDamage currentExtraDamage)
        {
            this.ObjectContext.ExtraDamage.AttachAsModified(currentExtraDamage, this.ChangeSet.GetOriginal(currentExtraDamage));
        }

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

        // TODO:
        // рассмотрите возможность сокращения результатов метода запроса.  Если необходим дополнительный ввод,
        // то в этот метод можно добавить параметры или создать дополнительные методы выполнения запроса с другими именами.
        // Для поддержки разбиения на страницы добавьте упорядочение в запрос "Insuarance".
        [Query(IsDefault = true)]
        public IQueryable<Insuarance> GetInsuarance()
        {
            return this.ObjectContext.Insuarance;
        }

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

        public void UpdateInsuarance(Insuarance currentInsuarance)
        {
            this.ObjectContext.Insuarance.AttachAsModified(currentInsuarance, this.ChangeSet.GetOriginal(currentInsuarance));
        }

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

        // TODO:
        // рассмотрите возможность сокращения результатов метода запроса.  Если необходим дополнительный ввод,
        // то в этот метод можно добавить параметры или создать дополнительные методы выполнения запроса с другими именами.
        // Для поддержки разбиения на страницы добавьте упорядочение в запрос "InsuaranceAgency".
        [Query(IsDefault = true)]
        public IQueryable<InsuaranceAgency> GetInsuaranceAgency()
        {
            return this.ObjectContext.InsuaranceAgency;
        }

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

        public void UpdateInsuaranceAgency(InsuaranceAgency currentInsuaranceAgency)
        {
            this.ObjectContext.InsuaranceAgency.AttachAsModified(currentInsuaranceAgency, this.ChangeSet.GetOriginal(currentInsuaranceAgency));
        }

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

        // TODO:
        // рассмотрите возможность сокращения результатов метода запроса.  Если необходим дополнительный ввод,
        // то в этот метод можно добавить параметры или создать дополнительные методы выполнения запроса с другими именами.
        // Для поддержки разбиения на страницы добавьте упорядочение в запрос "Make".
        [Query(IsDefault = true)]
        public IQueryable<Make> GetMake()
        {
            return this.ObjectContext.Make;
        }

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

        public void UpdateMake(Make currentMake)
        {
            this.ObjectContext.Make.AttachAsModified(currentMake, this.ChangeSet.GetOriginal(currentMake));
        }

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

        // TODO:
        // рассмотрите возможность сокращения результатов метода запроса.  Если необходим дополнительный ввод,
        // то в этот метод можно добавить параметры или создать дополнительные методы выполнения запроса с другими именами.
        // Для поддержки разбиения на страницы добавьте упорядочение в запрос "Model".
        [Query(IsDefault = true)]
        public IQueryable<Model> GetModel()
        {
            return this.ObjectContext.Model;
        }

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

        public void UpdateModel(Model currentModel)
        {
            this.ObjectContext.Model.AttachAsModified(currentModel, this.ChangeSet.GetOriginal(currentModel));
        }

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

        // TODO:
        // рассмотрите возможность сокращения результатов метода запроса.  Если необходим дополнительный ввод,
        // то в этот метод можно добавить параметры или создать дополнительные методы выполнения запроса с другими именами.
        // Для поддержки разбиения на страницы добавьте упорядочение в запрос "Order".
        [Query(IsDefault = true)]
        public IQueryable<Order> GetOrder()
        {
            return this.ObjectContext.Order;
        }

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

        public void UpdateOrder(Order currentOrder)
        {
            this.ObjectContext.Order.AttachAsModified(currentOrder, this.ChangeSet.GetOriginal(currentOrder));
        }

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

        // TODO:
        // рассмотрите возможность сокращения результатов метода запроса.  Если необходим дополнительный ввод,
        // то в этот метод можно добавить параметры или создать дополнительные методы выполнения запроса с другими именами.
        // Для поддержки разбиения на страницы добавьте упорядочение в запрос "OrdinaryDamage".
        [Query(IsDefault = true)]
        public IQueryable<OrdinaryDamage> GetOrdinaryDamage()
        {
            return this.ObjectContext.OrdinaryDamage;
        }

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

        public void UpdateOrdinaryDamage(OrdinaryDamage currentOrdinaryDamage)
        {
            this.ObjectContext.OrdinaryDamage.AttachAsModified(currentOrdinaryDamage, this.ChangeSet.GetOriginal(currentOrdinaryDamage));
        }

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

        // TODO:
        // рассмотрите возможность сокращения результатов метода запроса.  Если необходим дополнительный ввод,
        // то в этот метод можно добавить параметры или создать дополнительные методы выполнения запроса с другими именами.
        // Для поддержки разбиения на страницы добавьте упорядочение в запрос "PurchaseOrder".
        [Query(IsDefault = true)]
        public IQueryable<PurchaseOrder> GetPurchaseOrder()
        {
            return this.ObjectContext.PurchaseOrder;
        }

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

        public void UpdatePurchaseOrder(PurchaseOrder currentPurchaseOrder)
        {
            this.ObjectContext.PurchaseOrder.AttachAsModified(currentPurchaseOrder, this.ChangeSet.GetOriginal(currentPurchaseOrder));
        }

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

        // TODO:
        // рассмотрите возможность сокращения результатов метода запроса.  Если необходим дополнительный ввод,
        // то в этот метод можно добавить параметры или создать дополнительные методы выполнения запроса с другими именами.
        // Для поддержки разбиения на страницы добавьте упорядочение в запрос "Purchaser".
        [Query(IsDefault = true)]
        public IQueryable<Purchaser> GetPurchaser()
        {
            return this.ObjectContext.Purchaser;
        }

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

        public void UpdatePurchaser(Purchaser currentPurchaser)
        {
            this.ObjectContext.Purchaser.AttachAsModified(currentPurchaser, this.ChangeSet.GetOriginal(currentPurchaser));
        }

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

        // TODO:
        // рассмотрите возможность сокращения результатов метода запроса.  Если необходим дополнительный ввод,
        // то в этот метод можно добавить параметры или создать дополнительные методы выполнения запроса с другими именами.
        // Для поддержки разбиения на страницы добавьте упорядочение в запрос "Repair".
        [Query(IsDefault = true)]
        public IQueryable<Repair> GetRepair()
        {
            return this.ObjectContext.Repair;
        }

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

        public void UpdateRepair(Repair currentRepair)
        {
            this.ObjectContext.Repair.AttachAsModified(currentRepair, this.ChangeSet.GetOriginal(currentRepair));
        }

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

        // TODO:
        // рассмотрите возможность сокращения результатов метода запроса.  Если необходим дополнительный ввод,
        // то в этот метод можно добавить параметры или создать дополнительные методы выполнения запроса с другими именами.
        // Для поддержки разбиения на страницы добавьте упорядочение в запрос "Supplier".
        [Query(IsDefault = true)]
        public IQueryable<Supplier> GetSupplier()
        {
            return this.ObjectContext.Supplier;
        }

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

        public void UpdateSupplier(Supplier currentSupplier)
        {
            this.ObjectContext.Supplier.AttachAsModified(currentSupplier, this.ChangeSet.GetOriginal(currentSupplier));
        }

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

        // TODO:
        // рассмотрите возможность сокращения результатов метода запроса.  Если необходим дополнительный ввод,
        // то в этот метод можно добавить параметры или создать дополнительные методы выполнения запроса с другими именами.
        // Для поддержки разбиения на страницы добавьте упорядочение в запрос "SupplyOrder".
        [Query(IsDefault = true)]
        public IQueryable<SupplyOrder> GetSupplyOrder()
        {
            return this.ObjectContext.SupplyOrder;
        }

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

        public void UpdateSupplyOrder(SupplyOrder currentSupplyOrder)
        {
            this.ObjectContext.SupplyOrder.AttachAsModified(currentSupplyOrder, this.ChangeSet.GetOriginal(currentSupplyOrder));
        }

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

        // TODO:
        // рассмотрите возможность сокращения результатов метода запроса.  Если необходим дополнительный ввод,
        // то в этот метод можно добавить параметры или создать дополнительные методы выполнения запроса с другими именами.
        // Для поддержки разбиения на страницы добавьте упорядочение в запрос "TechnicalService".
        [Query(IsDefault = true)]
        public IQueryable<TechnicalService> GetTechnicalService()
        {
            return this.ObjectContext.TechnicalService;
        }

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

        public void UpdateTechnicalService(TechnicalService currentTechnicalService)
        {
            this.ObjectContext.TechnicalService.AttachAsModified(currentTechnicalService, this.ChangeSet.GetOriginal(currentTechnicalService));
        }

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
    }
}


