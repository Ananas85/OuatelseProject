using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ouatelse.Models;
using Ouatelse.Managers;
using Ouatelse;

namespace OuatelseTests
{
    /// <summary>
    /// Summary description for ManyCollectionTest
    /// </summary>
    [TestClass]
    public class ManyCollectionTest
    {
        Customer testCustomer = new Customer();
        List<Invoice> testInvoice = new List<Invoice>();
        Customer initialTestCustomer = new Customer();
        List<Invoice> initialTestInvoice = new List<Invoice>();

        public ManyCollectionTest()
        {
            initialTestCustomer = CustomerManager.Instance.Find(1);
            initialTestInvoice.Add(InvoiceManager.Instance.Find(1));
            initialTestInvoice.Add(InvoiceManager.Instance.Find(2));
        }

        [TestInitialize()]
        public void TestInit()
        {
            TestDatabase.Instance.InitDatabase();

            testCustomer = CustomerManager.Instance.Find(1);
            testInvoice.Add(InvoiceManager.Instance.Find(1));
            testInvoice.Add(InvoiceManager.Instance.Find(2));
        }

        [TestMethod]
        public void TestAdd()
        {
            testCustomer.Invoices.Add(testInvoice[0]);
            testCustomer.Invoices.Add(testInvoice[1]);
            int i = 0;

            foreach (Invoice test in testCustomer.Invoices.Items)
            {
                Assert.AreEqual(test, testInvoice[i]);
                i++;
            }
        }

        [TestMethod]
        public void TestReload()
        {
            testCustomer.Invoices.Add(testInvoice[0]);
            testCustomer.Invoices.Add(testInvoice[1]);
            testCustomer.Invoices.Reload();
            int i = 0;

            foreach (Invoice test in testCustomer.Invoices.Items)
            {
                Assert.AreEqual(test, testInvoice[i]);
                i++;
            }
        }

        [TestMethod]
        public void TestDelete()
        {
            testCustomer.Invoices.Add(testInvoice[0]);
            testCustomer.Invoices.Delete(testInvoice[0]);
            testCustomer.Invoices.Reload();
            Assert.AreEqual(0, testCustomer.Invoices.Items.Length);
        }

        [TestMethod]
        public void TestDeleteAll()
        {
            testCustomer.Invoices.Add(testInvoice[0]);
            testCustomer.Invoices.Add(testInvoice[1]);
            testCustomer.Invoices.DeleteAll();
            testCustomer.Invoices.Reload();
            Assert.AreEqual(0, testCustomer.Invoices.Items.Length);
        }
    }
}
