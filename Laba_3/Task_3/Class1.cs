using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Date
    {
        private int _day;
        private int _month;
        private int _year;
        private string _monthstr = "";
        private readonly bool _flag = true;

        public Date()//базовый конструктор
        {
            _day = 0;
            _month = 0;
            _year = 0;
        }
        public Date(int day, int month, int year)//с введением данных
        {
            _flag = Proverka(day, month, year);//вызов метода на проверку данных
            _monthstr = ConvertMonthToString(month);//конвертация числа в слово месяца
        }
        public void Print()//вывод на экран
        {
            if (_flag)
            {
                Console.WriteLine("Введенная дата : {0} {1} {2}", _day, _monthstr, _year);
                Sravnenie(_day, _month, _year);//вызов метода сравнения текущей и введеннолй даты
            }
        }
        public string ConvertMonthToString(int month)//Конвертируем месяц в строку.
        {
            string[] strMonthArr = { "Янв", "Фев", "Maрт", "Апр", "Мая", "Июня", "Июля", "Авг", "Сент", "Окт", "Нояб", "Дек" };
            _monthstr = strMonthArr[month - 1];
            return _monthstr;
        }

        public bool Proverka(int day, int month, int year)//метод проверки введенной даты
        {
            if (day >= 1 && day <= 31 && month >= 1 && month <= 12 && year > 0)
            {
                _day = day;
                _month = month;
                _year = year;
                return true;
            }
            Console.WriteLine("Введен не правильный день, месяц или год");
            return false;
        }
        public static void Sravnenie(int day, int month, int year)//метод сравнения даты
        {
            Console.WriteLine("Сегодня : {0}", DateTime.Today.ToShortDateString());
            System.DateTime date1 = new System.DateTime(year, month, day);
            System.DateTime date2 = DateTime.Today;
            System.TimeSpan diff2 = date2 - date1;
            Console.WriteLine("Дней мужду датами: ");
            Console.Write(Math.Abs(diff2.Days));
            //if (_day < DateTime.Today.Day || _month < DateTime.Today.Month || _year < DateTime.Today.Year)
            //    Console.WriteLine("Текущаяя дата больше введенной");
            //else
            //    Console.WriteLine("Текущаяя дата меньше введенной");
        }

        public void currentdayofweek(string date)
        {
            int day = (date[0] - '0') * 10 + date[1] - '0';
            int month = (date[3] - '0') * 10 + date[4] - '0';
            int year = (date[6] - '0') * 1000 + (date[7] - '0') * 100 + (date[8] - '0') * 10 + (date[9] - '0');

            System.DateTime date1 = new System.DateTime(year, month, day);
            Console.Write("День недели: ");
            Console.Write(date1.DayOfWeek);
        }

    }
}
