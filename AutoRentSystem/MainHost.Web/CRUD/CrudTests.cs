using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;

namespace MainHost.Web.CRUD
{
    [TestFixture]
    public class CrudTests
    {
        #region Cities

        [Test]
        public void GetCitiesTest()
        {
            List<City> listAct = CrudOperations

            List<City> listEtalon = new List<City>();
            listEtalon.Add(new City { Id = 1, Name = "Kiev", Country = context.Countries.Find(1) });
            listEtalon.Add(new City { Id = 2, Name = "Lviv", Country = context.Countries.Find(1) });
            listEtalon.Add(new City { Id = 3, Name = "Moscow", Country = context.Countries.Find(2) });
            listEtalon.Add(new City { Id = 4, Name = "Volgograd", Country = context.Countries.Find(2) });
            listEtalon.Add(new City { Id = 5, Name = "Koln", Country = context.Countries.Find(4) });
            listEtalon.Add(new City { Id = 6, Name = "Berlin", Country = context.Countries.Find(4) });
            listEtalon.Add(new City { Id = 7, Name = "Krakov", Country = context.Countries.Find(3) });

            Assert.True(CompareCityLists(listEtalon, listAct));
        }

        [Test]
        public void GetCitiesByCountryId()
        {
            List<City> listAct = service.GetCitiesByCountryId(4);

            List<City> listEtalon = new List<City>();
            listEtalon.Add(new City { Id = 5, Name = "Koln", Country = context.Countries.Find(4) });
            listEtalon.Add(new City { Id = 6, Name = "Berlin", Country = context.Countries.Find(4) });

            Assert.True(CompareCityLists(listEtalon, listAct));
        }

        [Test]
        public void UpdateCity()
        {
            service.UpdateCity(new City() { Id = 4, Name = "Tombov", Country = new Country { Id = 2, Name = "Russia" } });
            List<City> listAct = service.GetCities();

            List<City> listEtalon = new List<City>();
            listEtalon.Add(new City { Id = 1, Name = "Kiev", Country = context.Countries.Find(1) });
            listEtalon.Add(new City { Id = 2, Name = "Lviv", Country = context.Countries.Find(1) });
            listEtalon.Add(new City { Id = 3, Name = "Moscow", Country = context.Countries.Find(2) });
            listEtalon.Add(new City { Id = 4, Name = "Tombov", Country = context.Countries.Find(2) });
            listEtalon.Add(new City { Id = 5, Name = "Koln", Country = context.Countries.Find(4) });
            listEtalon.Add(new City { Id = 6, Name = "Berlin", Country = context.Countries.Find(4) });
            listEtalon.Add(new City { Id = 7, Name = "Krakov", Country = context.Countries.Find(3) });

            Assert.True(CompareCityLists(listEtalon, listAct));
        }

        [Test]
        public void InsertCity()
        {
            int id = service.InsertCity(new City { Name = "Tver", Country = new Country { Id = 2, Name = "Russia" } });
            List<City> listAct = service.GetCities();

            List<City> listEtalon = new List<City>();
            listEtalon.Add(new City { Id = 1, Name = "Kiev", Country = context.Countries.Find(1) });
            listEtalon.Add(new City { Id = 2, Name = "Lviv", Country = context.Countries.Find(1) });
            listEtalon.Add(new City { Id = 3, Name = "Moscow", Country = context.Countries.Find(2) });
            listEtalon.Add(new City { Id = 4, Name = "Volgograd", Country = context.Countries.Find(2) });
            listEtalon.Add(new City { Id = 5, Name = "Koln", Country = context.Countries.Find(4) });
            listEtalon.Add(new City { Id = 6, Name = "Berlin", Country = context.Countries.Find(4) });
            listEtalon.Add(new City { Id = 7, Name = "Krakov", Country = context.Countries.Find(3) });
            listEtalon.Add(new City { Id = 8, Name = "Tver", Country = context.Countries.Find(2) });

            Assert.True(CompareCityLists(listEtalon, listAct));
            Assert.AreEqual(8, id);
        }

        [Test]
        public void DeleteCity()
        {
            service.DeleteCity(6);
            List<City> listAct = service.GetCities();

            List<City> listEtalon = new List<City>();
            listEtalon.Add(new City { Id = 1, Name = "Kiev", Country = context.Countries.Find(1) });
            listEtalon.Add(new City { Id = 2, Name = "Lviv", Country = context.Countries.Find(1) });
            listEtalon.Add(new City { Id = 3, Name = "Moscow", Country = context.Countries.Find(2) });
            listEtalon.Add(new City { Id = 4, Name = "Volgograd", Country = context.Countries.Find(2) });
            listEtalon.Add(new City { Id = 5, Name = "Koln", Country = context.Countries.Find(4) });
            listEtalon.Add(new City { Id = 7, Name = "Krakov", Country = context.Countries.Find(3) });

            Assert.True(CompareCityLists(listEtalon, listAct));
        }

        #endregion
    }
}