using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число");
            int num = Convert.ToInt32(Console.ReadLine());

            int a, b;
            a = num / 100;
            b = (num % 100 - num % 10) / 10;

            int c = (a > b) ? a : b;
            if (c == a)
            {
                b = 0;
                Console.WriteLine("Первое больше второго");
            }
            else
            {
                b = 1;
                Console.WriteLine("Второе больше первого");
            }
        }
    }
}
