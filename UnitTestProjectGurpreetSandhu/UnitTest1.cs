using System;
using Car_Race_GurpreetSandhu;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectGurpreetSandhu
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            GurpreetSandhuGreyhound truck = new GurpreetSandhuGreyhound();
            Assert.AreEqual(23, truck.truckStartingPos);
        }
    }
}
