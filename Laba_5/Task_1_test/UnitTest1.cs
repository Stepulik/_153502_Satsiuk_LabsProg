using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _5;

namespace Task_1_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Potreblenye potreblenye = new Potreblenye();
            potreblenye.addTar("voda", 130);
            potreblenye.addTar("elektr", 1500);
            potreblenye.addTar("otoplenye", 500);

            potreblenye.AddUser("OLEG");
            potreblenye.login("OLEG");
            potreblenye.BuyTarifes("voda");
            potreblenye.BuyTarifes("otoplenye");
            potreblenye.logout();

            int x = potreblenye.GetTotalSum();
            Assert.AreEqual(630, x);

        }
        public void TestMethod2()
        {
            Potreblenye potreblenye = new Potreblenye();
            potreblenye.addTar("voda", 130);
            potreblenye.addTar("elektr", 1500);
            potreblenye.addTar("otoplenye", 500);
            potreblenye.AddUser("OLEG");
            potreblenye.login("OLEG");
            potreblenye.BuyTarifes("voda");
            potreblenye.BuyTarifes("otoplenye");
            potreblenye.logout();

            Users x = potreblenye.GetByName("DMITRI");
            Assert.AreEqual(x, null);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Potreblenye potreblenye = new Potreblenye();
            potreblenye.addTar("voda", 130);
            potreblenye.addTar("elektr", 1500);
            potreblenye.addTar("otoplenye", 500);
            potreblenye.AddUser("OLEG");

            Tarify x = potreblenye.GetTarByTitle("voda"); // cost : 130
            Tarify y = new Tarify("voda", 130); // cost : 130
            
            int q = x.cost;
            int w = y.cost;
            Assert.AreEqual(q, w);
        }


        [TestMethod]
        public void TestMethod4()
        {
            Potreblenye potreblenye = new Potreblenye();
            potreblenye.addTar("voda", 130);
            potreblenye.addTar("elektr", 1500);
            potreblenye.addTar("otoplenye", 500);
            potreblenye.AddUser("OLEG");
            potreblenye.AddUser("DMITRI");

            potreblenye.login("OLEG"); // total : 630
            potreblenye.BuyTarifes("voda");
            potreblenye.BuyTarifes("otoplenye");
            potreblenye.logout();

            potreblenye.login("DMITRI"); // total : 2000
            potreblenye.BuyTarifes("otoplenye");
            potreblenye.BuyTarifes("elektr");
            potreblenye.logout();

            int x = potreblenye.GetTotalSum();
            Assert.AreEqual(2630, x);
        }


        [TestMethod]
        public void TestMethod6()
        {
            Potreblenye potreblenye = new Potreblenye();
            potreblenye.addTar("voda", 130);
            potreblenye.addTar("elektr", 1500);
            potreblenye.addTar("otoplenye", 500);
            potreblenye.AddUser("OLEG");
            potreblenye.AddUser("DMITRI");
            potreblenye.AddUser("PAVEL");


            potreblenye.login("OLEG"); // total : 630
            potreblenye.BuyTarifes("voda");
            potreblenye.BuyTarifes("otoplenye");
            potreblenye.logout();

            potreblenye.login("DMITRI"); // total : 2000
            potreblenye.BuyTarifes("otoplenye");
            potreblenye.BuyTarifes("elektr");
            potreblenye.logout();

            potreblenye.login("PAVEL"); // total : 1500
            potreblenye.BuyTarifes("elektr");
            potreblenye.logout();

            int x = potreblenye.GetTotalSum(); // all : 4130
            Assert.AreEqual(4130, x);
        }

    }
}
