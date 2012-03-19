using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ServiceTests
{
    [TestFixture]
    public class GuestDomainServiceTests
    {
        DomainServiceTest service;
        List<City> cities;

        [TestFixtureSetUp]
        public void SetUp()
        {
            service = new DomainServiceTest();
            cities = new List<City>() { new City () {Id = 1, Name = "Dnipropetrovsk"},
                                        new City () {Id = 2, Name = "Kiev"} };            
        }

        [Test]
        public void GetCityTest()
        {

            List<City> list = new List<City>();
            list = service.GetCity().ToList();
            Assert.True(CompareCityList(cities, list));
        }

        private bool CompareCities(City cityEt, City cityAct)
        {
            bool areEqual = false;

            if (cityEt == null && cityAct == null)
            {
                areEqual = true;
            }
            else if (cityEt != null && cityAct != null)
            {           
                if (cityEt.Id == cityAct.Id && cityEt.Name == cityAct.Name)
                {
                    Console.WriteLine("{0}, {1}", cityAct.Id, cityAct.Name);
                    areEqual = true;
                }                
            }
            return areEqual;
        }

        private bool CompareCityList(List<City> citiesEt, List<City> citiesAct)
        {
            bool areEqual = false;

            if (citiesEt.Count == citiesAct.Count)
            {
                if (citiesAct.Count == 0)
                {
                    areEqual = true;
                }
                else
                {
                    for (int i = 0; i < citiesAct.Count; i++)
                    {
                        if (!CompareCities(citiesEt[i], citiesAct[i]))
                        {
                            break;
                        }
                        if (i == citiesAct.Count - 1)
                        {
                            areEqual = true;
                        }
                    }
                }
            }
                      
            return areEqual;
        }
    }
}
