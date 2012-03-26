using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Model;
using DAL.Administration;

namespace DALTests
{
    [TestFixture]
    public class PermissionAccessTest
    {
        [Test]
        public void AuthorizeYes()
        {
            PermissionAccess pa = new PermissionAccess();
            Assert.AreEqual(true, pa.Authorize("Petr", "Petr"));
        }

        [Test]
        public void AuthorizeNo()
        {
            PermissionAccess pa = new PermissionAccess();
            Assert.AreEqual(false, pa.Authorize("Jj", "k"));
        }
    }
}
