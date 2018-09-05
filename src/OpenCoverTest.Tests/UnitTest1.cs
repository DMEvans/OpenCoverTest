using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenCoverTest.Library;

namespace OpenCoverTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateTest()
        {
            var multiplier = new Multiplier();

            var value1 = 10;
            var value2 = 10;

            var result = multiplier.Calculate(value1, value2);

            Assert.AreEqual(100, result);
        }
    }
}
