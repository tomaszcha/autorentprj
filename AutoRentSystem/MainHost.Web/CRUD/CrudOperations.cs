using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MainHost.Web.Models;

namespace MainHost.Web.CRUD
{

    public class CrudOperations
    {
        #region CRUD operations for City

        /// <summary>
        /// Gets a list of cities
        /// </summary>
        /// <returns>List of cities</returns>
        public List<City> GetCities()
        {
            using (AutoRentEntities autoRentEntities = new AutoRentEntities())
            {
                IQueryable<City> cities = autoRentEntities.City.Select(o => o);
                return cities.ToList();
            }
        }


        /// <summary>
        /// Inserts city
        /// </summary>
        /// <param name="city">City to insert</param>
        /// <returns>Inserted city id</returns>
        public int InsertCity(City city)
        {
            using (AutoRentEntities autoRentEntities = new AutoRentEntities())
            {
                autoRentEntities.City.AddObject(city);
                autoRentEntities.SaveChanges();

                int id = (autoRentEntities.City.Select(o => o).ToList().Last()).Id;
                return id;
            }
        }

        
        /// <summary>
        /// Updates city
        /// </summary>
        /// <param name="city">City to update</param>
        public void UpdateCity(City updCity)
        {
            using (AutoRentEntities autoRentEntities = new AutoRentEntities())
            {
                City qCity = (from city in autoRentEntities.City where city.Id == updCity.Id select city).First();
                qCity = updCity;
                autoRentEntities.SaveChanges();                
            }
        }
        
        /// <summary>
        /// Delete city
        /// </summary>
        /// <param name="id">City id</param>
        public void DeleteCountry(int id)
        {
            using (AutoRentEntities autoRentEntities = new AutoRentEntities())
            {
                City city = (from ccity in autoRentEntities.City where ccity.Id==id select ccity).First();
                autoRentEntities.City.DeleteObject(city);
                autoRentEntities.SaveChanges();
            }
        }
       
        #endregion
    }
}