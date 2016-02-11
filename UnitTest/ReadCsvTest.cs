using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreOffice;

namespace UnitTest
{
    /// <summary>
    /// Summary description for ReadCsvTest
    /// http://www.codeproject.com/Articles/9715/How-to-Test-Private-and-Protected-methods-in-NET
    /// </summary>
    [TestClass]
    public class ReadCsvTest
    {
        [TestMethod]
        public void TestItemsCollectionIsNotNull()
        {
            Assert.IsNotNull(Program.items);
        }

        [TestMethod]
        public void TestCanReadCsvFile()
        {
            string path = "data/ReadTest.csv";
            int expected = 26;

            Program.ReadCsvFile(path, false);

            Assert.IsNotNull(Program.items);
            Assert.AreEqual(Program.items.Count, expected);
        }
    }
}
