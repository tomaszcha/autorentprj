
namespace MainHost.Web.Services
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;
    using MainHost.Web.Models;


    [EnableClientAccess()]
    public class GuestDomainService : LinqToEntitiesDomainService<AutoRentEntities>
    {
        /// <summary>
        /// Gets applications
        /// </summary>
        /// <returns>Applications</returns>
        public IQueryable<Application> GetApplication()
        {
            return this.ObjectContext.Application;
        }


        /// <summary>
        /// Inserts an application
        /// </summary>
        /// <param name="application">Application to insert</param>
        public void InsertApplication(Application application)
        {
            if ((application.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(application, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Application.AddObject(application);
            }
        }
            
  
        /// <summary>
        /// Gets autos
        /// </summary>
        /// <returns>Autos</returns>
        public IQueryable<Auto> GetAuto()
        {
            return this.ObjectContext.Auto;
        }
                

        /// <summary>
        /// Gets categories
        /// </summary>
        /// <returns>Categories</returns>
        public IQueryable<Category> GetCategory()
        {
            return this.ObjectContext.Category;
        }


        /// <summary>
        /// Gets cities
        /// </summary>
        /// <returns>Cities</returns>
        public IQueryable<City> GetCity()
        {
            return this.ObjectContext.City;
        }


        /// <summary>
        /// Gets department
        /// </summary>
        /// <returns>Departments</returns>
        public IQueryable<Department> GetDepartment()
        {
            return this.ObjectContext.Department;
        }


        /// <summary>
        /// Gets makes
        /// </summary>
        /// <returns>Makes</returns>
        public IQueryable<Make> GetMake()
        {
            return this.ObjectContext.Make;
        }
        

        /// <summary>
        /// Gets models
        /// </summary>
        /// <returns>Models</returns>
        public IQueryable<Model> GetModel()
        {
            return this.ObjectContext.Model;
        }
    }
}


