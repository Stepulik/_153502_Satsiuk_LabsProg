using System;
using Task_3;


    Console.Write("Введите год, месяц и день (через точку): ");
    var parts = Console.ReadLine().Split('.');//разделение даты на составляющие
    var date1 = new Date(int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2]));//создание об через полныйконструктор
    date1.Print();//писанина даты на экран

Console.WriteLine("\nВведите год, месяц и день (через точку): ");
string date2 = Console.ReadLine();
date1.currentdayofweek(date2);
    Console.ReadKey();
      