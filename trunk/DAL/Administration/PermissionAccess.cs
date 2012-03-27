using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.Common;

namespace DAL.Administration
{
    public class PermissionAccess : IPermissionAccess
    {

        #region IPermissionAccess Members

        public RulesInRole CheckPermissionForUser(string login, PermissionRule permission)
        {
            RulesInRole res = null;
            AutoRentEntities context = new AutoRentEntities();
            IEnumerable<RulesInRole> list =
               from roles in context.Members.First(o => o.Login == login).Roles
               from perm in context.PermissionRule
               from rulesInRole in context.RulesInRole
               where rulesInRole.RoleId == roles.Id && rulesInRole.PermId == perm.Id
               select rulesInRole;
            if (list != null)
                res = list.First();
            return res;

        }

        public RulesInRole CheckPermissionForRole(Roles role, PermissionRule permission)
        {
            RulesInRole res = null;
            AutoRentEntities context = new AutoRentEntities();
            IEnumerable<RulesInRole> list =
               from perm in context.PermissionRule
               from rulesInRole in context.RulesInRole
               where rulesInRole.RoleId == role.Id && rulesInRole.PermId == perm.Id
               select rulesInRole;
            if (list != null)
                res = list.First();
            return res;
        }

        public List<PermissionRule> GetPermissionsListForRole(Roles role)
        {
            AutoRentEntities context = new AutoRentEntities();
            IEnumerable<PermissionRule> list =
               from perm in context.PermissionRule
               from rulesInRole in context.RulesInRole
               where rulesInRole.RoleId == role.Id && rulesInRole.PermId == perm.Id
               select perm;
            return list.ToList();
        }

        public List<PermissionRule> GetPermissionsListForLogin(string login)
        {
            AutoRentEntities context = new AutoRentEntities();
            IEnumerable<PermissionRule> list =
               from roles in context.Members.First(o => o.Login == login).Roles
               from perm in context.PermissionRule
               from rulesInRole in context.RulesInRole
               where rulesInRole.RoleId == roles.Id && rulesInRole.PermId == perm.Id
               select perm;
            return list.ToList();
        }

        public bool Authorize(string login, string passwd)
        {
            AutoRentEntities context = new AutoRentEntities();
            return context.Members.Any(o => o.Lock == false && o.Login == login && o.Password == passwd);
        }

        #endregion IPermissionAccess Members

    }
}
