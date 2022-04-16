using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_
{
    public class Rate
    {
        public Rate()
        {

        }

        private int numofpeople;

        public int Numofpeople
        {
            get { return numofpeople; }
            set { numofpeople = value; }
        }

        private int numofpay;

        public int Numofpay
        {
            get { return numofpay; }
            set { numofpay = value; }
        }

        private double payPerMonth;

        public double PayPerMonth
        {
            get { return payPerMonth; }
            set { payPerMonth = value; }
        }

        public int Debtersnum
        {
            get { return Numofpeople - Numofpay; }
        }

        private double debt;

        public double Debt
        {
            get { return PayPerMonth * (Numofpeople - Numofpay); }
        }

    }

}