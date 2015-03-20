using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ouatelse;
using Ouatelse.Managers;
using Ouatelse.Models;

namespace OuatelseTests
{
    /// <summary>
    /// Classe de test du base manager, les méthodes particulières seront testées dans les autres manager
    /// Le count n'a pas besoin d'être tester, il est tester lors de l'exécution des autres tests
    /// </summary>
    [TestClass]
    public class BaseManagerTest
    {
        [TestMethod]
        public void TestAll()
        {
            //Juste pour pas qu'il y'est qu'une seule données
            GenderManager.Instance.Save(new Gender() { Name = "Transgenre" });
            int count = GenderManager.Instance.Count();
            Gender[] genders = GenderManager.Instance.All();
            Assert.AreEqual(count, genders.Length);

        }

        [TestMethod]
        public void TestFilter()
        {
            //Juste pour pas qu'il y'est qu'une seule données
            GenderManager.Instance.Save(new Gender() { Name = "Transgenre" });
            int count = GenderManager.Instance.Count();
            Gender[] genders = GenderManager.Instance.Filter("WHERE nom = 'Transgenre'");
            Assert.IsTrue(genders.Length > 0);
        }

        [TestMethod]
        public void TestFirst()
        {
           Assert.IsTrue(GenderManager.Instance.Count() > 1);
           Assert.IsTrue(GenderManager.Instance.First("").Id == 1); 
            
        }

        [TestMethod]
        public void TestSave()
        {
            int count = GenderManager.Instance.Count();
            Gender gender = new Gender { Name = "Autres" };
            GenderManager.Instance.Save(gender);
            Assert.AreEqual(count + 1, GenderManager.Instance.Count());
            Assert.AreEqual("Autres", GenderManager.Instance.First("WHERE nom = 'Autres' ").Name);

        }

        [TestMethod]
        public void TestFind()
        {
            Assert.AreEqual(1, GenderManager.Instance.Find(1).Id);
        }

        [TestMethod]
        public void TestDelete()
        {
            GenderManager.Instance.Truncate();
            Gender gender = new Gender {Name = "TestR"};
            int initialCount = GenderManager.Instance.Count();
            GenderManager.Instance.Save(gender);
            int count = initialCount + 1;
            Assert.AreEqual(count,GenderManager.Instance.Count());
            GenderManager.Instance.Delete(gender);
            Assert.AreEqual(initialCount, GenderManager.Instance.Count());

        }

        [TestMethod]
        public void TestTruncate()
        {
            int count = GenderManager.Instance.Count();
            Gender gender = new Gender { Name = "Autres" };
            GenderManager.Instance.Save(gender);
            Assert.AreEqual(count + 1, GenderManager.Instance.Count());
            GenderManager.Instance.Truncate();
            Assert.AreEqual(0, GenderManager.Instance.Count());

        }
    }
}