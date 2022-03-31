using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Services
{
    internal class Class1
    {
        private double pi = 3.14;
        private double x;
        private double y;
        private double z;
        private double b;
        public void func()
        {
            Console.Write("Enter z: ");
            z = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter b: ");
            b = Convert.ToDouble(Console.ReadLine());

            if (z < 1)
            {
                x = z / b;
                Console.Write("num of brunch = 1; ");
            }
            if (z >= 1)
            {
                x = Math.Sqrt((z / b) * (z / b) * (z / b));
                Console.Write("num of brunch = 2; ");
            }

            y = -pi + Math.Cos(x * x * x) * Math.Cos(x * x * x) + Math.Sin(x * x) + Math.Sin(x * x) + Math.Sin(x * x);
            Console.Write("y = ");
            Console.Write(y);
        }
    }
}
