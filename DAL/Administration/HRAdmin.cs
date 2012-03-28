using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.Common;

namespace DAL.Administration
{
    public class HRAdmin: IHRAdmin
    {
        #region IHRAdmin members

        /// <summary>
        /// Create new employee profile
        /// </summary>
        /// <param name="employee">Added employee</param>
        public Guid CreateEmployeProfile(Employee employee)
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

        /// <summary>
        /// Create new customer profile
        /// </summary>
        /// <param name="employee">Added customer</param>
        public Guid CreateCustomerProfile(Customer customer)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                customer.Id = Guid.NewGuid();
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();
                context.AddToCustomer(customer);
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
            return customer.Id;
        }

        public void RemoveEmployeProfile(Guid guid)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();                
                
                context.Employee.DeleteObject(context.Employee.First(o => o.Id == guid));

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
        }

        public void RemoveCustomerProfile(Guid guid)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();

                context.Customer.DeleteObject(context.Customer.First(o => o.Id == guid));

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
        }

        public List<Members> UsersInRole(string roleName)
        {
            AutoRentEntities context = new AutoRentEntities();
            return context.Roles.First(o => o.Name == roleName).Members.ToList();
        }

        public void RemoveUsersFromRoles(string[] logins, Roles[] roles)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();

                foreach (string login in logins)
                {
                    Members member = context.Members.First(o => o.Login == login);
                    foreach (Roles role in roles)
                    {
                        member.Roles.Remove(role);
                    }
                }

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
        }

        public void AddUsersToRoles(string[] logins, Roles[] roles)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();

                foreach (string login in logins)
                {
                    Members member = context.Members.First(o => o.Login == login);
                    foreach (Roles role in roles)
                    {
                        member.Roles.Add(role);
                    }
                }

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
        }

        public List<Roles> RolesForLogin(string login)
        {
            AutoRentEntities context = new AutoRentEntities();
            IEnumerable<Roles> list =
              from roles in context.Members.First(o => o.Login == login).Roles
              from rulesInRole in context.RulesInRole
            where rulesInRole.RoleId == roles.Id
              select roles;
            return list.ToList(); 
        }

        public void Lock(string login)
        {
            AutoRentEntities context = new AutoRentEntities();
            IEnumerable<Members> members = 
                from memb in context.Members
                where memb.Login==login
                select memb;
            if (members != null)
            {
                Members member = members.First();
                DbTransaction transaction = null;
                try
                {
                    context.Connection.Open();
                    transaction = context.Connection.BeginTransaction();

                    member.Lock = true;

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
            }
        }

        public void UnLock(string login)
        {
            AutoRentEntities context = new AutoRentEntities();
            IEnumerable<Members> members =
                from memb in context.Members
                where memb.Login == login
                select memb;
            if (members != null)
            {
                Members member = members.First();
                DbTransaction transaction = null;
                try
                {
                    context.Connection.Open();
                    transaction = context.Connection.BeginTransaction();

                    member.Lock = false;

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
            }
        }

        public void Registrate(Members member)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();
                context.AddToMembers(member);
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
        }

        #endregion IHRAdmin members
    }
}
