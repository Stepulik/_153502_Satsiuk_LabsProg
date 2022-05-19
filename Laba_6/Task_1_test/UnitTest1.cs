using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task_1_test;

namespace Task_1_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var glass = new Beer("White bear", 140, 14, 240);

            Assert.AreEqual(glass.Name, "White bear");
        }

        [TestMethod]
        public void TestMethod2()
        {
            var glass = new Beer("White bear", 140, 14, 240);

            Assert.AreEqual(glass.strenght, 14);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var glass = new Beer("White bear", 140, 14, 240);

            Assert.AreEqual(glass.cost, 140);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var glass = new Beer("White bear", 140, 14, 240);

            Assert.AreEqual(glass.volume, 240);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var glass = new Whisky("BlackJesus", 565, 34, 100);
            glass.addice();
            Assert.AreEqual(glass.volume, 110);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var glass = new Whisky("BlackJesus", 565, 30, 100);
            glass.addice();
            Assert.AreEqual(glass.strenght, 27);
        }


        [TestMethod]
        public void TestMethod7()
        {
            var glass = new Whisky("BlackJesus", 565, 30, 100);
            Assert.AreEqual(glass.whithice, false);
        }
    

    [TestMethod]
        public void TestMethod8()
        {
            var glass = new Whisky("BlackJesus", 565, 30, 100);
            glass.addice();
            Assert.AreEqual(glass.whithice, true);
        }
    }
}

