using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task_1;

namespace Task_1_test
{
    [TestClass]
    public class UnitTest1
    {
        Interval FirstObject = new Interval();
        Interval SecondObject = new Interval(10, 20);
        Interval ThirdObject = new Interval(5, 7);
        Interval FourthObject = new Interval(15, 17.5);
        Interval FifthObject;
        Interval SixthObject = new Interval(9.5, 17.5);
        [TestMethod]
        public void Test1()
        {
            FirstObject.Beginning = -1;
            FirstObject[1] = 1;
            Assert.AreEqual(2, FirstObject.GetLength());
        }

        [TestMethod]
        public void Test2()
        {
            FifthObject = ThirdObject + SecondObject;
            Assert.AreEqual(12, FifthObject.GetLength());
        }

        [TestMethod]
        public void Test3()
        {
            FifthObject = SecondObject - ThirdObject;
            Assert.AreEqual(8, FifthObject.GetLength());
        }

        [TestMethod]
        public void Test4()
        {
            FifthObject = SecondObject * ThirdObject;
            Assert.AreEqual(0, FifthObject.GetLength());
        }

        [TestMethod]
        public void Test5()
        {
            FifthObject = SecondObject * FourthObject;
            Assert.AreEqual(2.5, FifthObject.GetLength());
        }

        [TestMethod]
        public void Test6()
        {
            FifthObject = SecondObject * SixthObject;
            Assert.AreEqual(7.5, FifthObject.GetLength());
        }

        [TestMethod]
        public void Test7()
        {
            FirstObject++;
            ++FirstObject;
            FirstObject++;
            ++FirstObject;
            Assert.AreEqual(8, FirstObject.GetLength());
        }

        [TestMethod]
        public void Test8()
        {
            SecondObject--;
            --SecondObject;
            Assert.AreEqual(6, SecondObject.GetLength());
        }

        [TestMethod]
        public void Test9()
        {
            Assert.IsTrue(FourthObject > ThirdObject);
        }

        [TestMethod]
        public void Test10()
        {
            Assert.IsFalse(FourthObject < ThirdObject);
        }

        [TestMethod]
        public void Test11()
        {
            FourthObject.Beginning = 9;
            FourthObject.End = 11;
            Assert.IsTrue(ThirdObject == FourthObject);
        }

        [TestMethod]
        public void Test12()
        {
            Assert.IsTrue(ThirdObject != FourthObject);
        }

        [TestMethod]
        public void Test13()
        {
            Assert.IsFalse(FourthObject >= SixthObject);
        }

        [TestMethod]
        public void Test14()
        {
            Assert.IsTrue(FourthObject <= SixthObject);
        }

        [TestMethod]
        public void Test15()
        {
            bool Status;
            if (FirstObject)
            {
                Status = true;
            }
            else
            {
                Status = false;
            }
            Assert.IsFalse(Status);
        }

        [TestMethod]
        public void Test16()
        {
            bool Status;
            if (SecondObject)
            {
                Status = true;
            }
            else
            {
                Status = false;
            }
            Assert.IsTrue(Status);
        }

        [TestMethod]
        public void Test17()
        {
            Assert.AreEqual(2.5, (double)FourthObject);
        }

        [TestMethod]
        public void Test18()
        {
            FifthObject = (Interval)22.5;
            Assert.AreEqual(0, FifthObject[0]);
        }

        [TestMethod]
        public void Test19()
        {
            FifthObject = (Interval)22.5;
            Assert.AreEqual(22.5, FifthObject.End);
        }

        [TestMethod]
        public void Test20()
        {
            Assert.AreEqual("Beginning = 5, End = 7, Length = 2", ThirdObject.ToString());
        }
    }
}
