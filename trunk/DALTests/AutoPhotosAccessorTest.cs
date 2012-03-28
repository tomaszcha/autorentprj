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
    public class AutoPhotosAccessorTest
    {   
        [Test]
        public void CreateAutoPhotosTest()
        {  
            AutoPhotosAccessor accessor = new AutoPhotosAccessor();
            AutoPhotos autoPhoto = new AutoPhotos
            {
                AutoNumber = "AA 5676 CH",  
                DoDate = new DateTime(2011, 12, 28),
                PhotoFileName = "photo1.jpg"             
            };
            accessor.CreateAutoPhotos(autoPhoto);
        }

        [Test]
        public void UpdateAutoPhotosTest()
        {
            AutoPhotosAccessor accessor = new AutoPhotosAccessor();
            AutoPhotos autoPhotos = new AutoPhotos
            {
                AutoNumber = "AA 5676 CH",
                DoDate = new DateTime(2011, 12, 28),
                PhotoFileName = "photo_5.jpg"
            };

            accessor.UpdateAutoPhotos(autoPhotos);
        }

        [Test]
        public void GetAutoPhotosTest()
        {
            AutoPhotosAccessor accessor = new AutoPhotosAccessor();
            List<AutoPhotos> autoPhotoss = accessor.GetAutoPhotoss();
            foreach (AutoPhotos aph in autoPhotoss)
            {
                Console.WriteLine("{0}, {1}, {2}", aph.AutoNumber, aph.DoDate, aph.PhotoFileName);
            }
        }

        [Test]
        public void RemoveAutoPhotos()
        {
            AutoPhotosAccessor accessor = new AutoPhotosAccessor();
            accessor.RemoveAutoPhotos("AA 5676 CH", new DateTime(2011, 12, 28));
        }
    }
}
