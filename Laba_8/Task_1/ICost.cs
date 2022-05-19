using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    interface ICost
    {
        double GetCost();
    }

    class WhithBenefits : ICost
    {
        double cost;
        public WhithBenefits(double cost, int prosents)
        {   

            this.cost = cost;
            int p = prosents;
            if(p < 0 || p > 100)
            {
                p = 0;
            }
            this.cost = cost - cost * p / 100;
        }


        public double GetCost()
        {
            return cost;
        }

    }
    class WhithoutBenefits : ICost
    {
        double cost;

        public WhithoutBenefits(double cost)
        {
            this.cost = cost;
        }
        public double GetCost()
        {
            return cost;
        }
    }
}
