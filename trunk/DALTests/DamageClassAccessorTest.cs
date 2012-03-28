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
            DamageClassAccessor deptAccessor = new DamageClassAccessor();
            DamageClass DamageClass = new DamageClass
            {
                Class = 2,
                Name = "Motor"               
            };
            deptAccessor.CreateDamageClass(DamageClass);
        }

        [Test]
        public void UpdateDamageClassTest()
        {
            DamageClassAccessor deptAccessor = new DamageClassAccessor();
            DamageClass DamageClass = new DamageClass
            {
                Class = 2,
                Name = "Bumper"
            };

            deptAccessor.UpdateDamageClass(DamageClass);
        }

        [Test]
        public void GetDamageClasssTest()
        {
            DamageClassAccessor deptAccessor = new DamageClassAccessor();
            List<DamageClass> DamageClasss = deptAccessor.GetDamageClasss();
            foreach (DamageClass d in DamageClasss)
            {
                Console.WriteLine("{0}, {1}", d.Class, d.Name);
            }
        }


        [Test]
        public void RemoveDamageClass()
        {
            DamageClassAccessor deptAccessor = new DamageClassAccessor();
            deptAccessor.RemoveDamageClass(2);
        }
    }
}
