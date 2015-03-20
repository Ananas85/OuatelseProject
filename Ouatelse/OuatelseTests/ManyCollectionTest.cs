using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ouatelse.Models;
using Ouatelse.Managers;

namespace OuatelseTests
{
    /// <summary>
    /// Summary description for ManyCollectionTest
    /// </summary>
    [TestClass]
    public class ManyCollectionTest
    {
        Customer testCustomer = new Customer();
        Invoice testInvoice = new Invoice();

        public ManyCollectionTest()
        {
            testCustomer = CustomerManager.Instance.Find(1);
            testInvoice = InvoiceManager.Instance.Find(1);
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestAdd()
        {
            testCustomer.Invoices.Add(testInvoice);

            int i = 0;
            foreach (Invoice test in testCustomer.Invoices.Items)
            {
                Assert.AreEqual(testInvoice, test);
            }
        }
    }
}
