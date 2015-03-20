using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ouatelse.Managers;
using Ouatelse.Models;

namespace OuatelseTests
{
    [TestClass]
    public class IModelTest
    {
        [TestMethod]
        public void makeExistant()
        {
            Gender gender = new Gender {Name = "TestMakeExistant"};
            Assert.IsFalse(gender.Exists);
            GenderManager.Instance.Save(gender);
            Assert.IsTrue(gender.Exists);

        }
    }
}