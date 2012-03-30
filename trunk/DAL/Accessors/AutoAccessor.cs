using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.Common;

namespace DAL.Accessors
{
    public class AutoAccessor
    {
        #region AutoAccessor members

        /// <summary>       
        /// Get list of autos
        /// </summary>          
        /// <returns>List of autos</returns>   
        public List<Auto> GetAutos()
        {
            AutoRentEntities context = new AutoRentEntities();
            List<Auto> Autos = new List<Auto>();
            try
            {
                Autos = (from auto in context.Auto
                               orderby auto.Number
                               select auto).ToList();
            }
            catch { }
            finally
            {
                context.Connection.Close();
            }

            return Autos;
        }


        /// <summary>
        /// Create new auto
        /// </summary>
        /// <param name="auto">Auto to add</param>
        public void CreateAuto(Auto auto)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {                
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();
                context.AddToAuto(auto);
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
        /// Update auto
        /// </summary>
        /// <param name="Auto">Auto to update</param>
        public void UpdateAuto(Auto auto)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();

                context.Auto.Attach(context.Auto.Single(o => o.Number == auto.Number));
                context.Auto.ApplyCurrentValues(auto);

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
        /// Remove auto
        /// </summary>
        /// <param name="number">Number of the auto to delete</param>
        public void RemoveAuto(string number)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();

                context.Auto.DeleteObject(context.Auto.First(o => o.Number == number));

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
