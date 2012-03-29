
namespace Main.Web.DomainModel
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
    using Main.Web.Model;
    using System.Data.Common;


    // Implements application logic using the AutoRentEntities context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class AutoRentDomainService : LinqToEntitiesDomainService<AutoRentEntities>
    {
        /// <summary>
        /// Create new employee profile
        /// </summary>
        /// <param name="employee">Added employee</param>
        public Guid CreateEmployeeProfile(Employee employee)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                employee.Id = Guid.NewGuid();
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();
                context.AddToEmployee(employee);
                context.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
            }
            finally
            {
                context.Connection.Close();
            }
            return employee.Id;
        }


        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Auto' query.
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
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'AutoPhotos' query.
        public IQueryable<AutoPhotos> GetAutoPhotos()
        {
            return this.ObjectContext.AutoPhotos;
        }

        public void InsertAutoPhotos(AutoPhotos autoPhotos)
        {
            if ((autoPhotos.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(autoPhotos, EntityState.Added);
            }
            else
            {
                this.ObjectContext.AutoPhotos.AddObject(autoPhotos);
            }
        }

        public void UpdateAutoPhotos(AutoPhotos currentAutoPhotos)
        {
            this.ObjectContext.AutoPhotos.AttachAsModified(currentAutoPhotos, this.ChangeSet.GetOriginal(currentAutoPhotos));
        }

        public void DeleteAutoPhotos(AutoPhotos autoPhotos)
        {
            if ((autoPhotos.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(autoPhotos, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.AutoPhotos.Attach(autoPhotos);
                this.ObjectContext.AutoPhotos.DeleteObject(autoPhotos);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Customer' query.
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
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'DamageClass' query.
        public IQueryable<DamageClass> GetDamageClass()
        {
            return this.ObjectContext.DamageClass;
        }

        public void InsertDamageClass(DamageClass damageClass)
        {
            if ((damageClass.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(damageClass, EntityState.Added);
            }
            else
            {
                this.ObjectContext.DamageClass.AddObject(damageClass);
            }
        }

        public void UpdateDamageClass(DamageClass currentDamageClass)
        {
            this.ObjectContext.DamageClass.AttachAsModified(currentDamageClass, this.ChangeSet.GetOriginal(currentDamageClass));
        }

        public void DeleteDamageClass(DamageClass damageClass)
        {
            if ((damageClass.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(damageClass, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.DamageClass.Attach(damageClass);
                this.ObjectContext.DamageClass.DeleteObject(damageClass);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Damages' query.
        public IQueryable<Damages> GetDamages()
        {
            return this.ObjectContext.Damages;
        }

        public void InsertDamages(Damages damages)
        {
            if ((damages.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(damages, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Damages.AddObject(damages);
            }
        }

        public void UpdateDamages(Damages currentDamages)
        {
            this.ObjectContext.Damages.AttachAsModified(currentDamages, this.ChangeSet.GetOriginal(currentDamages));
        }

        public void DeleteDamages(Damages damages)
        {
            if ((damages.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(damages, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Damages.Attach(damages);
                this.ObjectContext.Damages.DeleteObject(damages);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Department' query.
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
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Employee' query.
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
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Members' query.
        public IQueryable<Members> GetMembers()
        {
            return this.ObjectContext.Members;
        }

        public void InsertMembers(Members members)
        {
            if ((members.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(members, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Members.AddObject(members);
            }
        }

        public void UpdateMembers(Members currentMembers)
        {
            this.ObjectContext.Members.AttachAsModified(currentMembers, this.ChangeSet.GetOriginal(currentMembers));
        }

        public void DeleteMembers(Members members)
        {
            if ((members.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(members, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Members.Attach(members);
                this.ObjectContext.Members.DeleteObject(members);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Order' query.
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
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Payment' query.
        public IQueryable<Payment> GetPayment()
        {
            return this.ObjectContext.Payment;
        }

        public void InsertPayment(Payment payment)
        {
            if ((payment.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(payment, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Payment.AddObject(payment);
            }
        }

        public void UpdatePayment(Payment currentPayment)
        {
            this.ObjectContext.Payment.AttachAsModified(currentPayment, this.ChangeSet.GetOriginal(currentPayment));
        }

        public void DeletePayment(Payment payment)
        {
            if ((payment.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(payment, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Payment.Attach(payment);
                this.ObjectContext.Payment.DeleteObject(payment);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'PermissionRule' query.
        public IQueryable<PermissionRule> GetPermissionRule()
        {
            return this.ObjectContext.PermissionRule;
        }

        public void InsertPermissionRule(PermissionRule permissionRule)
        {
            if ((permissionRule.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(permissionRule, EntityState.Added);
            }
            else
            {
                this.ObjectContext.PermissionRule.AddObject(permissionRule);
            }
        }

        public void UpdatePermissionRule(PermissionRule currentPermissionRule)
        {
            this.ObjectContext.PermissionRule.AttachAsModified(currentPermissionRule, this.ChangeSet.GetOriginal(currentPermissionRule));
        }

        public void DeletePermissionRule(PermissionRule permissionRule)
        {
            if ((permissionRule.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(permissionRule, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.PermissionRule.Attach(permissionRule);
                this.ObjectContext.PermissionRule.DeleteObject(permissionRule);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Revisions' query.
        public IQueryable<Revisions> GetRevisions()
        {
            return this.ObjectContext.Revisions;
        }

        public void InsertRevisions(Revisions revisions)
        {
            if ((revisions.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(revisions, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Revisions.AddObject(revisions);
            }
        }

        public void UpdateRevisions(Revisions currentRevisions)
        {
            this.ObjectContext.Revisions.AttachAsModified(currentRevisions, this.ChangeSet.GetOriginal(currentRevisions));
        }

        public void DeleteRevisions(Revisions revisions)
        {
            if ((revisions.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(revisions, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Revisions.Attach(revisions);
                this.ObjectContext.Revisions.DeleteObject(revisions);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Roles' query.
        public IQueryable<Roles> GetRoles()
        {
            return this.ObjectContext.Roles;
        }

        public void InsertRoles(Roles roles)
        {
            if ((roles.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(roles, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Roles.AddObject(roles);
            }
        }

        public void UpdateRoles(Roles currentRoles)
        {
            this.ObjectContext.Roles.AttachAsModified(currentRoles, this.ChangeSet.GetOriginal(currentRoles));
        }

        public void DeleteRoles(Roles roles)
        {
            if ((roles.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(roles, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Roles.Attach(roles);
                this.ObjectContext.Roles.DeleteObject(roles);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'RulesInRole' query.
        public IQueryable<RulesInRole> GetRulesInRole()
        {
            return this.ObjectContext.RulesInRole;
        }

        public void InsertRulesInRole(RulesInRole rulesInRole)
        {
            if ((rulesInRole.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(rulesInRole, EntityState.Added);
            }
            else
            {
                this.ObjectContext.RulesInRole.AddObject(rulesInRole);
            }
        }

        public void UpdateRulesInRole(RulesInRole currentRulesInRole)
        {
            this.ObjectContext.RulesInRole.AttachAsModified(currentRulesInRole, this.ChangeSet.GetOriginal(currentRulesInRole));
        }

        public void DeleteRulesInRole(RulesInRole rulesInRole)
        {
            if ((rulesInRole.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(rulesInRole, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.RulesInRole.Attach(rulesInRole);
                this.ObjectContext.RulesInRole.DeleteObject(rulesInRole);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'sysdiagrams' query.
        public IQueryable<sysdiagrams> GetSysdiagrams()
        {
            return this.ObjectContext.sysdiagrams;
        }

        public void InsertSysdiagrams(sysdiagrams sysdiagrams)
        {
            if ((sysdiagrams.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(sysdiagrams, EntityState.Added);
            }
            else
            {
                this.ObjectContext.sysdiagrams.AddObject(sysdiagrams);
            }
        }

        public void UpdateSysdiagrams(sysdiagrams currentsysdiagrams)
        {
            this.ObjectContext.sysdiagrams.AttachAsModified(currentsysdiagrams, this.ChangeSet.GetOriginal(currentsysdiagrams));
        }

        public void DeleteSysdiagrams(sysdiagrams sysdiagrams)
        {
            if ((sysdiagrams.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(sysdiagrams, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.sysdiagrams.Attach(sysdiagrams);
                this.ObjectContext.sysdiagrams.DeleteObject(sysdiagrams);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'TicketHistory' query.
        public IQueryable<TicketHistory> GetTicketHistory()
        {
            return this.ObjectContext.TicketHistory;
        }

        public void InsertTicketHistory(TicketHistory ticketHistory)
        {
            if ((ticketHistory.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(ticketHistory, EntityState.Added);
            }
            else
            {
                this.ObjectContext.TicketHistory.AddObject(ticketHistory);
            }
        }

        public void UpdateTicketHistory(TicketHistory currentTicketHistory)
        {
            this.ObjectContext.TicketHistory.AttachAsModified(currentTicketHistory, this.ChangeSet.GetOriginal(currentTicketHistory));
        }

        public void DeleteTicketHistory(TicketHistory ticketHistory)
        {
            if ((ticketHistory.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(ticketHistory, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.TicketHistory.Attach(ticketHistory);
                this.ObjectContext.TicketHistory.DeleteObject(ticketHistory);
            }
        }
    }
}


