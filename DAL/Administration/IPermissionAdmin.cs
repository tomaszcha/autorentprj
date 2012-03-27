﻿using System;
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
        void AddPermissionsToRole(string role, PermissionRule permissions, RulesInRole rulesInRole);
        void RemovePermissions(string role, PermissionRule permissions, RulesInRole rulesInRole);
        List<PermissionRule> PermissionsForRole(string role);
    }
}
