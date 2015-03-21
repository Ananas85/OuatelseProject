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
