using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.Common;

namespace DAL.Accessors
{
    public class AutoPhotosAccessor
    {
        #region AutoPhotosAccessor members

        /// <summary>
        /// Get list of auto photoss
        /// </summary>       
        public List<AutoPhotos> GetAutoPhotoss()
        {
            AutoRentEntities context = new AutoRentEntities();
            List<AutoPhotos> photos = new List<AutoPhotos>();
            try
            {
                photos = (from autoPhotos in context.AutoPhotos
                               orderby autoPhotos.AutoNumber, autoPhotos.DoDate
                               select autoPhotos).ToList();
            }
            catch { }
            finally
            {
                context.Connection.Close();
            }

            return photos;
        }


        /// <summary>
        /// Create new auto photo
        /// </summary>
        /// <param name="AutoPhotos">Auto photos to add</param>
        public void CreateAutoPhotos(AutoPhotos autoPhoto)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {                
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();
                context.AddToAutoPhotos(autoPhoto);
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
        /// Update auto photos
        /// </summary>
        /// <param name="autoPhoto">Auto photo to update</param>
        public void UpdateAutoPhotos(AutoPhotos autoPhoto)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();

                context.AutoPhotos.Attach(context.AutoPhotos.Single(o => o.AutoNumber == autoPhoto.AutoNumber && o.DoDate == autoPhoto.DoDate));
                context.AutoPhotos.ApplyCurrentValues(autoPhoto);

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
        /// Remove auto photos
        /// </summary>        
        /// <param name="number">Auto number</param>
        /// <param name="doDate">DoDate</param>
        public void RemoveAutoPhotos(string number, DateTime doDate)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();

                context.AutoPhotos.DeleteObject(context.AutoPhotos.First(o => o.AutoNumber == number && o.DoDate == doDate));

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
