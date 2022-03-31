using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Fx(a) > Fx(b) ? "a" : "b");
        }

        static double Fx(double x)
        {
            return (x - Math.Sin(x));
        }
    }
}