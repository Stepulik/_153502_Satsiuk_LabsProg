using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{

    class person
    {
        public string name;
        ICost icost;

        public int discount;

        public person(string name, ICost icost)
        {
            this.name = name;
            this.icost = icost;
        }

        public double GetCost()
        {
            return icost.GetCost();
        }


    }

    public class JES
    {
        List<person> perslist = new List<person>();

        public void AddPersonWhithoutBenefits(string name, double cost)
        {
            perslist.Add(new person(name, new WhithoutBenefits(cost)));
        }
        public void AddPersonWhithBenefits(string name, double cost, int procents)
        {
            perslist.Add(new person(name, new WhithBenefits(cost, procents)));
        }

        public double GetTotalCost()
        {
            double result = 0;

            foreach (person item in perslist)
            {
                result += item.GetCost();
            }

            return result;
        }
        public double GetCostByName(string name)
        {
            double result = 0;
            foreach (person item in perslist)
            {
                if (item.name == name)
                {
                    result += item.GetCost();
                }
            }
            return result;
        }

    }

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
            if (p < 0 || p > 100)
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
