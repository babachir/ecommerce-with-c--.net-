using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using cataloguehetm.Models;

namespace CataloguehetmTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDalCreationDadmin_ListerLesAdmins()
        {
            using (IDal dal = new Dal())
            {
                dal.CreateAdmin("bachir", "boumessaoud", "ba.bachir@hotmail.fr", "azerty123");
                List<Admin> admins = dal.GetAllAdmin();
                Assert.IsNotNull(admins);
                Assert.AreEqual(admins[0].Email, "ba.bachir@hotmail.fr");
                Assert.AreEqual(admins[0].Firstname, "bachir");
                Assert.AreEqual(admins[0].Lastname, "boumessaoud");
            }
        }
    }
}