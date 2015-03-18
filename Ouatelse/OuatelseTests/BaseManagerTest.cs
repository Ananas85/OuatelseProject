using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ouatelse;
using Ouatelse.Managers;
using Ouatelse.Models;

namespace OuatelseTests
{
    [TestClass]
    public class BaseManagerTest
    {
        [TestMethod]
        public void TestAll()
        {
            //Juste pour pas qu'il y'est qu'une seule données
            GenderManager.Instance.Save(new Gender() { Name = "Transgenre" });
            int count = GenderManager.Instance.Count();
            List<Gender> genders = new List<Gender>();
            genders = GenderManager.Instance.All().ToList();
            Assert.AreEqual(count, genders.Count);

        }

        [TestMethod]
        public void testFilter()
        {
            //Juste pour pas qu'il y'est qu'une seule données
            GenderManager.Instance.Save(new Gender() { Name = "Transgenre" });
            int count = GenderManager.Instance.Count();
            List<Gender> genders = new List<Gender>();
            genders = GenderManager.Instance.Filter("WHERE nom = \"Transgenre\"").ToList();
            Assert.AreEqual(count, genders.Count);
        }

        [TestMethod]
        public void TestSave()
        {
            int count = GenderManager.Instance.Count();
            Gender gender = new Gender { Name = "Autres" };
            GenderManager.Instance.Save(gender);
            Assert.AreEqual(count+1, GenderManager.Instance.Count());
            Assert.AreEqual("Autres", GenderManager.Instance.First("WHERE nom = \"Autres\" ").Name);

        }

        [TestMethod]
        public void TestDelete()
        {
            Gender gender = new Gender {Name = "TestR"};
            int initialCount = GenderManager.Instance.Count();
            GenderManager.Instance.Save(gender);
            int count = initialCount + 1;
            Assert.AreEqual(count,GenderManager.Instance.Count());
            Utils.Info(gender.Id.ToString());
            GenderManager.Instance.Delete(gender);
            Assert.AreEqual(initialCount, GenderManager.Instance.Count());

        }





    }
}