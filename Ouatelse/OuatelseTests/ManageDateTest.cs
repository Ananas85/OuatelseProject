using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ouatelse;

namespace OuatelseTests
{
    [TestClass]
    public class ManageDateTest
    {
        [TestMethod]
        public void TestExistingDay()
        {
            Assert.IsFalse(ManageDate.Instance.IsExistingDay(2,30));
            Assert.IsTrue(ManageDate.Instance.IsExistingDay(2,1));
        }

        [TestMethod]
        public void TestIsWorkingDay()
        {
           Assert.IsFalse(ManageDate.Instance.isWorkingDate(new DateTime(DateTime.Now.Year,12,25), DateTime.Now.Year));
        }

        [TestMethod]
        public void TestSortAscending()
        {
            List<DateTime> toSort = new List<DateTime>
            {
                new DateTime(DateTime.Now.Year, 1, 25),
                new DateTime(DateTime.Now.Year, 1, 14)

            };

            List<DateTime> sortedList = new List<DateTime>
            {
                new DateTime(DateTime.Now.Year,1,14),
                new DateTime(DateTime.Now.Year,1,25)
            };

            Assert.IsFalse(toSort[0] == sortedList[0]);
            toSort = ManageDate.Instance.SortAscending(toSort);
            Assert.IsTrue(toSort[0] == sortedList[0]);
        }
    }
}
