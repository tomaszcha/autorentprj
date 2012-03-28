using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.Common;

namespace DAL.Accessors
{
    public class RevisionsAccessor
    {
        #region RevisionsAccessor members

        /// <summary>
        /// Get list of revisions
        /// </summary>       
        public List<Revisions> GetRevisions()
        {
            AutoRentEntities context = new AutoRentEntities();
            List<Revisions> revis = new List<Revisions>();
            try
            {
                revis = (from revisions in context.Revisions
                        orderby revisions.Id
                        select revisions).ToList();
            }
            catch { }
            finally
            {
                context.Connection.Close();
            }

            return revis;
        }


        /// <summary>
        /// Create new revisions
        /// </summary>
        /// <param name="revisions">Revisions to add</param>
        public void CreateRevisions(Revisions revisions)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();
                context.AddToRevisions(revisions);
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
        /// Update revisions
        /// </summary>
        /// <param name="Revisions">Revisions to update</param>
        public void UpdateRevisions(Revisions revisions)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();

                context.Revisions.Attach(context.Revisions.Single(c => c.Id == revisions.Id));
                context.Revisions.ApplyCurrentValues(revisions);

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
        /// Remove revisions
        /// </summary>
        /// <param name="id">Id of the rvisions to delete</param>
        public void RemoveRevisions(int id)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();

                context.Revisions.DeleteObject(context.Revisions.First(o => o.Id == id));

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
