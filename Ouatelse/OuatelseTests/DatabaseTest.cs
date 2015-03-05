using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ouatelse;
using Ouatelse.Managers;
using Ouatelse.Models;

namespace OuatelseTests
{
    [TestClass]
    public class DatabaseTest
    {
        [TestMethod]
        public void unitTestDatabase()
        {
            Assert.AreEqual(true, DatabaseInjector.IsInUnitTest);
        }


        [TestMethod]
        public void TestAddGender()
        {
            Gender gender = new Gender();
            gender.Name = "Mr";
            GenderManager.Instance.Save(gender);
            Assert.AreEqual(1,GenderManager.Instance.Count());
        }

        public void TestRemoveGender()
        {

        }
    }
}
