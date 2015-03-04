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
        public void DatabaseConnection()
        {
            IDatabase db = DatabaseInjector.Database;
            Gender gender = new Gender();
            gender.Name = "Monsieur";
            GenderManager.Instance.Save(gender);
            Assert.Equals(1, GenderManager.Instance.Count());
        }
    }
}
