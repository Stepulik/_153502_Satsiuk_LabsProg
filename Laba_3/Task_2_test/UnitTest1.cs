using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Task_2_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int z = -1;
            double x;
            int b = 1;

            if (z >= 1)
            {
                x = z / b;
            }
            else
                x = 1;
            Assert.AreEqual(x, 1);
        }

        public void TestMethod2()
        {
            int z = -1;
            double x;
            int b = 1;

            if (z < 1)
            {
                x = z / b;
            }
            else
                x = 1;
            Assert.AreEqual(x, -1);
        }

        public void TestMethod3()
        {
            int z = -10;
            double x;
            int b = 1;

            if (z < 1)
            {
                x = z / b;
            }
            else
                x = 1;
            Assert.AreEqual(x, -10);
        }
    }
}
