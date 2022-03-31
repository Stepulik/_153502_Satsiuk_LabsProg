// See https://aka.ms/new-console-template for more information

bool is_true;
do
{
    is_true = false;
    int choise;
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

    Console.WriteLine("Желаете продолжить? (1 - да, 0 - нет)");
    choise = Convert.ToInt32(Console.ReadLine());
    switch (choise)
    {
        case 0:
            is_true = false;
            break;
        case 1:
            is_true = true;
            break;
    }
} while (is_true);