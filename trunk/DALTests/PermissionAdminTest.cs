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
    class PermissionAdminTest
    {
        [Test]
        public void AddObjPermissionRule()
        {
            PermissionAdmin admin = new PermissionAdmin();
            PermissionRule rule = new PermissionRule
            {
                Name = "Somethig",
                ObjectType = "Frrr"
            };
            admin.AddObjPermissionRule(rule);
        }
    }
}
