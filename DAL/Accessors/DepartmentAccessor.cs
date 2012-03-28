using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.Common;

namespace DAL.Accessors
{
    public class DepartmentAccessor
    {
        #region DepartmentAccessor members

        /// <summary>
        /// Get list of departments
        /// </summary>       
        public List<Department> GetDepartments()
        {           
            AutoRentEntities context = new AutoRentEntities();
            List<Department> departments = new List<Department>();
            try
            {
                departments = (from department in context.Department
                               orderby department.Id
                               select department).ToList();
            }
            catch { }
            finally
            {
                context.Connection.Close();
            }

            return departments;
        }


        /// <summary>
        /// Create new department
        /// </summary>
        /// <param name="department">Department to add</param>
        public Guid CreateDepartment(Department department)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                department.Id = Guid.NewGuid();
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();
                context.AddToDepartment(department);
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
            return department.Id;
        }


        /// <summary>
        /// Remove department
        /// </summary>
        /// <param name="guid">Guid of the department to delete</param>
        public void RemoveDepartment(Guid guid)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();

                context.Department.DeleteObject(context.Department.First(o => o.Id == guid));

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
        /// Update department
        /// </summary>
        /// <param name="department">Department to update</param>
        public void UpdateDepartment(Department department)
        {
            AutoRentEntities context = new AutoRentEntities();
            DbTransaction transaction = null;
            try
            {
                context.Connection.Open();
                transaction = context.Connection.BeginTransaction();
                
                context.Department.Attach(context.Department.Single(c => c.Id == department.Id));
                context.Department.ApplyCurrentValues(department);     
         
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
