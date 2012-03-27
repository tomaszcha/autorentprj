using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace DAL.Administration
{
    interface IPermissionAccess
    {
        RulesInRole CheckPermissionForUser(string login, PermissionRule permission);
        RulesInRole CheckPermissionForRole(Roles role, PermissionRule permission);
        List<PermissionRule> GetPermissionsListForRole(Roles role);
        List<PermissionRule> GetPermissionsListForLogin(string login);
        bool Authorize(string login, string passwd);
    }
}
