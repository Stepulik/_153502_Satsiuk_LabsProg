using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Task_1_test
{
    [TestClass]
    public class UnitTest1
    {
        static double Fx(double x)
        {
            return (x - Math.Sin(x));
        }

        [TestMethod]
        public void TestMethod1()
        {
            int a = 10;
            int b = 20;
            if (Fx(a) > Fx(b))
                Assert.IsTrue(true);
            else
                Assert.IsFalse(false);
        }

        public void TestMethod2()
        {
            int a = 1520;
            int b = -20;
            if (Fx(a) > Fx(b))
                Assert.IsTrue(true);
            else
                Assert.IsFalse(false);
        }

        public void TestMethod3()
        {
            double a = 14.2;
            double b = 152.11;
            if (Fx(a) < Fx(b))
                Assert.IsTrue(true);
            else
                Assert.IsFalse(false);
        }
    }
}
