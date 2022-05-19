using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            JES jes = new JES();

            jes.AddPersonWhithoutBenefits("A", 1000);
            jes.AddPersonWhithBenefits("B", 1000, 50);
            Console.WriteLine(jes.GetTotalCost());

            jes.AddPersonWhithBenefits("A", 2000, 50);

            Console.WriteLine(jes.GetCostByName("A"));
            
        }
    }
}
