using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.Common;

namespace DAL.Administration
{
    public class PermissionAdmin :IPermissionAdmin
    {
        #region IPermissionAdmin Members

        public void AddObjPermissionRule(PermissionRule rule)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();
                context.AddToPermissionRule(rule);
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

        public void RemoveObjPermissionRule(long id)
        {
            throw new NotImplementedException();
        }

        public void ListObjPermRulles()
        {
            throw new NotImplementedException();
        }

        public void AddPermissionsToRole(string role, string permid)
        {
            throw new NotImplementedException();
        }

        public void RemovePermissions(string role, string permid)
        {
            throw new NotImplementedException();
        }

        public void PermissionsForRole(string role)
        {
            throw new NotImplementedException();
        }

        #endregion IPermissionAdmin Members
    }
}
