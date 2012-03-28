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
    public class DamageClassAccessorTest
    {
        [Test]
        public void CreateDamageClassTest()
        {
            DamageClassAccessor accessor = new DamageClassAccessor();
            DamageClass DamageClass = new DamageClass
            {
                Class = 2,
                Name = "Motor"               
            };
            accessor.CreateDamageClass(DamageClass);
        }

        [Test]
        public void UpdateDamageClassTest()
        {
            DamageClassAccessor accessor = new DamageClassAccessor();
            DamageClass DamageClass = new DamageClass
            {
                Class = 2,
                Name = "Bumper"
            };

            accessor.UpdateDamageClass(DamageClass);
        }

        [Test]
        public void GetDamageClasssTest()
        {
            DamageClassAccessor accessor = new DamageClassAccessor();
            List<DamageClass> DamageClasss = accessor.GetDamageClasss();
            foreach (DamageClass d in DamageClasss)
            {
                Console.WriteLine("{0}, {1}", d.Class, d.Name);
            }
        }


        [Test]
        public void RemoveDamageClass()
        {
            DamageClassAccessor accessor = new DamageClassAccessor();
            accessor.RemoveDamageClass(2);
        }
    }
}
