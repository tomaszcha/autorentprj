using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.Common;

namespace DAL.Accessors
{
    public class DamageClassAccessor
    {
        #region DamageClassAccessor members

        /// <summary>
        /// Get list of damage classes
        /// </summary>       
        public List<DamageClass> GetDamageClasss()
        {
            AutoRentEntities context = new AutoRentEntities();
            List<DamageClass> damageClasses = new List<DamageClass>();
            try
            {
                damageClasses = (from damageClass in context.DamageClass
                         orderby damageClass.Class
                         select damageClass).ToList();
            }
            catch { }
            finally
            {
                context.Connection.Close();
            }

            return damageClasses;
        }


        /// <summary>
        /// Create new damage class
        /// </summary>
        /// <param name="damageClass">Damage class to add</param>
        public void CreateDamageClass(DamageClass damageClass)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();
                context.AddToDamageClass(damageClass);
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


        /// <summary>
        /// Update damage class
        /// </summary> 
        /// <param name="damageClass">Damage class to update</param>
        public void UpdateDamageClass(DamageClass damageClass)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();

                context.DamageClass.Attach(context.DamageClass.Single(o => o.Class == damageClass.Class));
                context.DamageClass.ApplyCurrentValues(damageClass);

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


        /// <summary>
        /// Remove DamageClass
        /// </summary>
        /// <param name="number">Number of the DamageClass to delete</param>
        public void RemoveDamageClass(int cls)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();

                context.DamageClass.DeleteObject(context.DamageClass.First(o => o.Class == cls));

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

        #endregion
    }
}
