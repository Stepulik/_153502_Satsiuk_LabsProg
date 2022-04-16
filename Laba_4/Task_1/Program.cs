using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1;
using Task_1_;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter jes name: ");
            jesrate.Area = Console.ReadLine();

            Console.WriteLine("Enter jes number: ");
            jesrate.Jesnum = Convert.ToInt32(Console.ReadLine());

            jesrate jes = jesrate.GetInstance();

            Console.WriteLine("Ener cost: ");
            jes.PayPerMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter peoples number: ");
            jes.Numofpeople = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter paying people number: ");
            jes.Numofpay = Convert.ToInt32(Console.ReadLine());



            //           company.Workers = workers;

            bool cont = true;

            while (cont)
            {
                Console.WriteLine("Посчитать кол-во должников - 1;");
                Console.WriteLine("Посчитать общий долг - 2;");
                Console.WriteLine("Изменить тариф - 3;");
                Console.WriteLine("Завершить - введите 4;");

                string temp = Console.ReadLine();

                switch (temp)
                {
                    case "1":
                        double general = jes.Debtersnum;
                        Console.WriteLine(general);
                        break;
                    case "2":
                        double gen = jes.Debt;
                        Console.WriteLine(gen);
                        break;
                    case "3":
                        Console.WriteLine("Enter new rate: ");
                        jes.PayPerMonth = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "4":
                        cont = false;
                        break;
                }
            }

        }
    }
}
