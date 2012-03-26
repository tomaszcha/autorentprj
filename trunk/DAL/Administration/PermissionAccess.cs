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

        public void CheckPermissionForUser(string login, string perm)
        {
            throw new NotImplementedException();
        }

        public void CheckPermissionForRole(string role, string perm)
        {
            throw new NotImplementedException();
        }

        public void GetPermissionsListForRole(string role)
        {
            throw new NotImplementedException();
        }

        public void GetPermissionsListForLogin(string login)
        {
            throw new NotImplementedException();
        }

        public bool Authorize(string login, string passwd)
        {
            AutoRentEntities context = new AutoRentEntities();
            return context.Members.Any(o => o.Login == login && o.Password == passwd);
        }

        #endregion IPermissionAccess Members
    }
}
