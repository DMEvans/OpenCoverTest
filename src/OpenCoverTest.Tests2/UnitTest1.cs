using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenCoverTest.Library;

namespace OpenCoverTest.Tests2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ExtraMethodTest()
        {
            var multiplier = new Multiplier();

            var value1 = 10;

            var result = multiplier.ExtraMethod(value1);

            Assert.AreEqual(10000, result);
        }
    }
}
