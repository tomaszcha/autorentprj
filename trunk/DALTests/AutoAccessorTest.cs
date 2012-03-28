using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Model;
using DAL.Accessors;

namespace DALTests
{
    [TestFixture]
    public class AutoAccessorTest
    {
        [Test]
        public void CreateAutoTest()
        {
            AutoAccessor accessor = new AutoAccessor();
            Auto auto = new Auto
            {
                Number = "AA 5676 CH",
                ModelName = "Ford Kuga",
                BodyType = 2,
                InsuaranceNumber = "055274854554100",
                Class = 1,
                Year = 2008,
                Mileage = 5000,
                Engine = 3,
                ColorGroup = "black",
                DayRate = 750,
                KmRate = 20,
                Status = 2
            };
            accessor.CreateAuto(auto);
        }

        [Test]
        public void UpdateAutoTest()
        {
            AutoAccessor accessor = new AutoAccessor();
            Auto auto = new Auto
            {
                Number = "AA 5676 CH",
                ModelName = "Ford Kuga",
                BodyType = 2,
                InsuaranceNumber = "0002111455551",
                Class = 1,
                Year = 2009,
                Mileage = 6000,
                Engine = 3,
                ColorGroup = "black",
                DayRate = 750,
                KmRate = 20,
                Status = 2
            };           
            
            accessor.UpdateAuto(auto);
        }

        [Test]
        public void GetAutosTest()
        {
            AutoAccessor accessor = new AutoAccessor();
            List<Auto> autos = accessor.GetAutos();
            foreach (Auto a in autos)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}",
                    a.Number, a.ModelName, a.BodyType, a.InsuaranceNumber, a.Class, a.Year, 
                    a.Mileage, a.Engine, a.ColorGroup, a.DayRate, a.KmRate, a.Status);
            }
        }

        
        [Test]
        public void RemoveAuto()
        {
            AutoAccessor accessor = new AutoAccessor();
            accessor.RemoveAuto("AA 5676 CH");           
        }
    }
}
