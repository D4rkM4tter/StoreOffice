using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreOffice;

namespace UnitTest
{
    [TestClass]
    public class WriteXmlTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = "data/ReadTest.csv";
            string outputFileName = "output.xml";

            Program.ReadCsvFile(path, false);
            Program.WriteFile(outputFileName, false);
        }
    }
}
