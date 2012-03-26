using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace DAL.Administration
{
    interface IPermissionAccess
    {
        void CheckPermissionForUser(string login, string perm);
        void CheckPermissionForRole(string role, string perm);
        void GetPermissionsListForRole(string role);
        void GetPermissionsListForLogin(string login);
        bool Authorize(string login, string passwd);
    }
}
