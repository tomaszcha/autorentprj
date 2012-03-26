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
        void ListObjPermRulles();
        void AddPermissionsToRole(string role, string permid);
        void RemovePermissions(string role, string permid);
        void PermissionsForRole(string role);
    }
}
