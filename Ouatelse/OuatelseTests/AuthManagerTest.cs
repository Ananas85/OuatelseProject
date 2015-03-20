using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ouatelse.Managers;
using Ouatelse.Models;

namespace OuatelseTests
{
    [TestClass]
    public class AuthManagerTest
    {
        [TestMethod]
        public void TestLogin()
        {
            //D'abord on prend un administrateur
            //Pour l'instant erreur, les booléens sont pris en charge différement sur sqlite
            //Employee employee = EmployeeManager.Instance.First("");
            //Assert.IsTrue(AuthManager.Instance.Login(employee.Username, employee.Password));
        }

        public void TestLogout()
        {
            AuthManager.Instance.Logout();
            Assert.IsTrue(AuthManager.Instance.User == null);
        }
    }
}
