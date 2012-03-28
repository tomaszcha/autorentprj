using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace DAL.Administration
{
    interface IHRAdmin
    {
        Guid CreateEmployeProfile(Employee employee);
        Guid CreateCustomerProfile(Customer customer);
        void Registrate(Members member);
        void RemoveEmployeProfile(Guid guid);
        void RemoveCustomerProfile(Guid guid);
        List<Members> UsersInRole(string roleName);
        void RemoveUsersFromRoles(string[] logins, Roles[] role);
        void AddUsersToRoles(string[] logins, Roles[] roles);
        List<Roles> RolesForLogin(string login);
        void Lock(string login);
        void UnLock(string login);
    }
}
