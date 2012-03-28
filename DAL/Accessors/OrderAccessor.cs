using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.Common;

namespace DAL.Accessors
{
    public class OrderAccessor
    {
        #region OrderAccessor members

        /// <summary>
        /// Get list of order
        /// </summary>       
        public List<Order> GetOrder()
        {
            AutoRentEntities context = new AutoRentEntities();
            List<Order> orders = new List<Order>();
            try
            {
                orders = (from order in context.Order
                        orderby order.Number
                        select order).ToList();
            }
            catch { }
            finally
            {
                context.Connection.Close();
            }

            return orders;
        }


        /// <summary>
        /// Create new order
        /// </summary>
        /// <param name="oder">Order to add</param>
        public void CreateOrder(Order order)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();
                context.AddToOrder(order);
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
        /// Update order
        /// </summary>
        /// <param name="order">Order to update</param>
        public void UpdateOrder(Order order)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();

                context.Order.Attach(context.Order.Single(o => o.Number == order.Number));
                context.Order.ApplyCurrentValues(order);

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
        /// Remove order
        /// </summary>
        /// <param name="id">Number of the order to delete</param>
        public void RemoveOrder(int number)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();

                context.Order.DeleteObject(context.Order.First(o => o.Number == number));

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
