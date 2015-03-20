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
        public void TestDatabase()
        {
            Assert.AreEqual(true, DatabaseInjector.IsInUnitTest);
        }
    }
}
