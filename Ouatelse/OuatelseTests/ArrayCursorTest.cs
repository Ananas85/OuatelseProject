using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ouatelse;

namespace OuatelseTests
{
    [TestClass]
    public class ArrayCursorTest
    {
        [TestMethod]
        public void TestReadAndNext()
        {
            IEnumerable<int> tabofInts = from value in Enumerable.Range(0, 9)
                                      select value;
            ArrayCursor<int> cursor = new ArrayCursor<int>(tabofInts);
            Assert.IsTrue(cursor.Read() == tabofInts.ToArray()[0]);
            Assert.IsTrue(cursor.Read() == tabofInts.ToArray()[1]);
        }

        [TestMethod]
        public void TestReset()
        {
            IEnumerable<int> tabofInts = from value in Enumerable.Range(0, 9)
                                         select value;
            ArrayCursor<int> cursor = new ArrayCursor<int>(tabofInts);
            Assert.IsTrue(cursor.Read() == tabofInts.ToArray()[0]);
            Assert.IsTrue(cursor.Read() == tabofInts.ToArray()[1]);
            cursor.Reset();
            Assert.IsTrue(cursor.Read() == tabofInts.ToArray()[0]);
        }

    }
}
