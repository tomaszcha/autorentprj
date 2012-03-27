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

        public List<PermissionRule> ListObjPermRulles()
        {
            AutoRentEntities context = new AutoRentEntities();
            return context.PermissionRule.Select(o => o).ToList();
        }

        public void AddPermissionsToRole (Roles role, PermissionRule permission, RulesInRole rulesInRole)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();

                //Roles roles = context.Roles.First(o => o.Name == role);
                rulesInRole.RoleId = role.Id;
                rulesInRole.PermId = permission.Id;
                
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

        public void RemovePermissions(Roles role, PermissionRule[] permissions)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();

                foreach (PermissionRule perm in permissions)
                {
                    RulesInRole rules = context.RulesInRole.First(o => o.RoleId == role.Id && o.PermId == perm.Id);
                    context.RulesInRole.DeleteObject(rules);
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

        #endregion IPermissionAdmin Members
    }
}
