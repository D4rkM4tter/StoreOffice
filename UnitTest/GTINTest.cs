using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreOffice;

namespace UnitTest
{
    [TestClass]
    public class GTINTest
    {
        [TestMethod]
        public void TestAllFalse()
        {
            foreach (var item in GetAllFalse())
            {
                bool result = DomainHelper.CheckGTIN(item.GTIN);
                Assert.AreEqual(result, item.expected);
            }
        }

        [TestMethod]
        public void TestAllTrue()
        {

            foreach (var item in GetAllTrue())
            {
                bool result = DomainHelper.CheckGTIN(item.GTIN);
                Assert.AreEqual(result, item.expected);
            }
        }

        [TestMethod]
        public void TestMixed()
        {

            foreach (var item in GetMixed())
            {
                bool result = DomainHelper.CheckGTIN(item.GTIN);
                Assert.AreEqual(result, item.expected);
            }
        }

        internal List<GTINWrapper> GetAllFalse()
        {
            List<GTINWrapper> wrappers = new List<GTINWrapper>
            {
                new GTINWrapper(false, "45496332549"),
                new GTINWrapper(false, "45496332709"),
                new GTINWrapper(false, "45496332778")
            };

            return wrappers;
        }

        internal List<GTINWrapper> GetAllTrue()
        {
            List<GTINWrapper> wrappers = new List<GTINWrapper>
            {
                new GTINWrapper(true, "2092042200000"),
                new GTINWrapper(true, "2092300600000"),
                new GTINWrapper(true, "2092301200000"),
                new GTINWrapper(true, "2092301700000"),
                new GTINWrapper(true, "2098478500000"),
                new GTINWrapper(true, "2098479100000"),
                new GTINWrapper(true, "2098480600000")
            };

            return wrappers;
        }

        internal List<GTINWrapper> GetMixed()
        {
            List<GTINWrapper> wrappers = new List<GTINWrapper>
            {
                new GTINWrapper(true, "2092042200000"),
                new GTINWrapper(true, "2092300600000"),
                new GTINWrapper(true, "2092301200000"),
                new GTINWrapper(false, "45496332549"),
                new GTINWrapper(false, "45496332709"),
                new GTINWrapper(true, "2092301700000"),
                new GTINWrapper(true, "2098478500000"),
                new GTINWrapper(true, "2098479100000"),
                new GTINWrapper(false, "45496332709"),
                new GTINWrapper(true, "2098480600000")
            };

            return wrappers;
        }

        internal class GTINWrapper
        {
            public GTINWrapper(bool flagga, string gtin)
            {
                expected = flagga;
                GTIN = gtin; 
            }

            public bool expected;
            public string GTIN;
        }
    }
}
