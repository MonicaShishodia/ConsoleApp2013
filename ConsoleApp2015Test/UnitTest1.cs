using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2015;
namespace ConsoleApp2015Test
{
    [TestClass]
    public class UnitTest1 
    {
        ConsoleApp2015.BusinessLayer bl = null;
        [TestMethod]
        public void TestEmptyNumbers()
        {
            bl = new BusinessLayer();
            Assert.AreEqual(bl.CheckEmptyNumbers(" "),false);
        }
        [TestMethod]
        public void TestIfNumbers()
        {
            bl = new BusinessLayer();
            Assert.AreEqual(bl.CheckIfNumbers("hdh"), false);
        }
        [TestMethod]
        public void TestCalculation()
        {
            bl = new BusinessLayer();
            Assert.IsTrue(bl.AddNumbers(19, 10)== 29);
        }
    }
}
