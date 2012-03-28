using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.Common;

namespace DAL.Accessors
{
    public class DamagesAccessor
    {
        #region DamagesAccessor members

        /// <summary>
        /// Get list of damages
        /// </summary>       
        public List<Damages> GetDamages()
        {
            AutoRentEntities context = new AutoRentEntities();
            List<Damages> dmgs = new List<Damages>();
            try
            {
                dmgs = (from damages in context.Damages
                               orderby damages.Id
                               select damages).ToList();
            }
            catch { }
            finally
            {
                context.Connection.Close();
            }

            return dmgs;
        }


        /// <summary>
        /// Create new damages
        /// </summary>
        /// <param name="damages">Damages to add</param>
        public void CreateDamages(Damages damages)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {                
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();
                context.AddToDamages(damages);
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
        /// Update damages
        /// </summary>
        /// <param name="damages">Damages to update</param>
        public void UpdateDamages(Damages damages)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();

                context.Damages.Attach(context.Damages.Single(c => c.Id == damages.Id));
                context.Damages.ApplyCurrentValues(damages);

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
        /// Remove damages
        /// </summary>
        /// <param name="id">Id of the damages to delete</param>
        public void RemoveDamages(int id)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();

                context.Damages.DeleteObject(context.Damages.First(o => o.Id == id));

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
