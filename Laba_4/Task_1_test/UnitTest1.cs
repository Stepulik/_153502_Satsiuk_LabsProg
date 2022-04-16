using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task_1;
using Task_1_;

namespace Task_1_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            jesrate jes = jesrate.GetInstance();
            jes.Numofpay = 1000;
            jes.Numofpeople = 1200;


            Assert.AreEqual(200, jes.Debtersnum);

        }

        [TestMethod]
        public void TestMethod2()
        {
            jesrate jes = jesrate.GetInstance();
            jes.Numofpay = 1800;
            jes.Numofpeople = 2200;


            Assert.AreEqual(400, jes.Debtersnum);
        }
        [TestMethod]
        public void TestMethod3()
        {
            jesrate jes = jesrate.GetInstance();
            jes.Numofpay = 0;
            jes.Numofpeople = 2200;


            Assert.AreEqual(2200, jes.Debtersnum);
        }

        [TestMethod]
        public void TestMethod4()
        {
            jesrate jes = jesrate.GetInstance();
            jes.Numofpay = 1800;
            jes.Numofpeople = 2200;
            jes.PayPerMonth = 10;


            Assert.AreEqual(4000, jes.Debt);
        }
        [TestMethod]
        public void TestMethod5()
        {
            jesrate jes = jesrate.GetInstance();
            jes.Numofpay = 10;
            jes.Numofpeople = 200;
            jes.PayPerMonth = 1;


            Assert.AreEqual(190, jes.Debt);
        }
        
    }
}
