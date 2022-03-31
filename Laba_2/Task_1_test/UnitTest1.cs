using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;



namespace Task_1_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReturnNum2()
        {
            int num = 231;

            int a;
            a = num / 100;
            Assert.AreEqual(a, 2);
        }

        [TestMethod]
        public void ReturnNum3()
        {
            int num = 321;

            int a;
            a = num / 100;
            Assert.AreEqual(a, 3);
        }

        [TestMethod]
        public void ReturnNum6()
        {
            int num = 361;

            int b;
            b = (num % 100 - num % 10) / 10; ;
            Assert.AreEqual(b, 6);
        }

        [TestMethod]
        public void ReturnTrue1()
        {
            int num = 631;

            int a, b;
            a = num / 100;
            b = (num % 100 - num % 10) / 10;

            int c = (a > b) ? a : b;
            if(c == a)
                Assert.IsTrue(true);
            else
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void ReturnTrue2()
        {
            int num = 361;

            int a, b;
            a = num / 100;
            b = (num % 100 - num % 10) / 10;

            int c = (a > b) ? a : b;
            if (c != a)
                Assert.IsTrue(true);
            else
            Assert.IsTrue(false);
        }
    }
}

