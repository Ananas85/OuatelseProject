using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ouatelse.Managers;
using Ouatelse.Models;

namespace OuatelseTests
{
    [TestClass]
    public class BaseManagerTest
    {
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
        public void TestRemove()
        {
            Gender gender = new Gender {Name = "TestR"};
            int count = GenderManager.Instance.Count();
            GenderManager.Instance.Save(gender);
            Assert.AreEqual(count+1,GenderManager.Instance.Count());
            GenderManager.Instance.Delete(gender);
            Assert.AreEqual(count, GenderManager.Instance.Count());

        }

        [TestMethod]
        public void TestAll()
        {
            //Juste pour pas qu'il y'est qu'une seule données
            GenderManager.Instance.Save(new Gender() {Name = "Transgenre"});
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
            genders = GenderManager.Instance.All().ToList();
            Assert.AreEqual(count, genders.Count);
        }

    }
}