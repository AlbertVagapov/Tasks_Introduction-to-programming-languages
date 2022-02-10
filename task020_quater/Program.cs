// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти: ");
int x = int.Parse(Console.ReadLine());

if (x >= 1 && x <= 4)
{
    if (x == 1)
    {
        Console.WriteLine("x > 0, y > 0");
    }
    else if (x==2)
    {
        Console.WriteLine("x < 0, y > 0");
    }
    else if(x==3)
    {
        Console.WriteLine("x < 0, y < 0");
    }
    else if(x==4)
    {
        Console.WriteLine("x > 0, y < 0");
    }
}
else
{
    Console.WriteLine("Введите целое число от 1 до 4");
}