using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task_1;

namespace Task_1_test
{
    [TestClass]
    public class UnitTest1
    {

        
        [TestMethod]
        public void TestMethod1()
        {
            JES jes = new JES();

            jes.AddPersonWhithoutBenefits("A", 1000);
            jes.AddPersonWhithBenefits("B", 1000, 50);

            Assert.AreEqual(jes.GetTotalCost(), 1500);
        }

        [TestMethod]
        public void TestMethod2()
        {
            JES jes = new JES();

            jes.AddPersonWhithoutBenefits("A", 1000);
            jes.AddPersonWhithBenefits("B", 1000, 100);

            Assert.AreEqual(jes.GetTotalCost(), 1000);
        }


        [TestMethod]
        public void TestMethod3()
        {
            JES jes = new JES();

            jes.AddPersonWhithoutBenefits("A", 1000);
            jes.AddPersonWhithBenefits("B", 1000, 50);

            Assert.AreEqual(jes.GetCostByName("A"), 1000);
        }


        [TestMethod]
        public void TestMethod4()
        {
            JES jes = new JES();

            jes.AddPersonWhithoutBenefits("A", 1000);
            jes.AddPersonWhithBenefits("B", 1000, 50);

            Assert.AreEqual(jes.GetCostByName("B"), 500);
        }
    }

}
