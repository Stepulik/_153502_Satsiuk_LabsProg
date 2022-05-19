using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class JES
    {
        List<person> perslist = new List<person> ();

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
                if(item.name == name)
                {
                    result += item.GetCost();
                }
            }    
            return result;
        }
        
    }
}
