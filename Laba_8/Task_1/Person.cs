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
}
