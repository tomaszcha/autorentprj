using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace DAL.Administration
{
    interface IPermissionAdmin
    {
        void AddObjPermissionRule(PermissionRule rule);
        void RemoveObjPermissionRule(long id);
        List<PermissionRule> ListObjPermRulles();
        void AddPermissionsToRole(Roles role, PermissionRule permissions, RulesInRole rulesInRole);
        void RemovePermissions(Roles role, PermissionRule[] permissions);
    }
}
