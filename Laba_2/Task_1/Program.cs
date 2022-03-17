// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

int a, b;
a = num / 100;
b = (num % 100 - num % 10) / 10;

int c = (a > b) ? a : b;
if (c == a)
{
    Console.WriteLine("Первое больше второго");
}
else
    Console.WriteLine("Второе больше первого");
