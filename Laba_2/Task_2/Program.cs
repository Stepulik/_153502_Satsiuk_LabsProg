// See https://aka.ms/new-console-template for more information


bool is_true;
do
{
    is_true = false;
    int choise;
    Console.WriteLine("Введите координаты точки по х:");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координаты точки по у:");
    int y = Convert.ToInt32(Console.ReadLine());

    if(x > 40 || y > 40 || x < -40 || y < -40)
        Console.WriteLine("Да");
    else if (x == 40 || y == 40)
        Console.WriteLine("На границе");
    else
        Console.WriteLine("Нет");

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