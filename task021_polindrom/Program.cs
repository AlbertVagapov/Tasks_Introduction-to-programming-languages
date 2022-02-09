// Программа проверяет пятизначное число на палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int x = int.Parse(Console.ReadLine());

if (x / 10000 > 0 && x / 10000 < 10)
{
    if (x / 10000 == x % 10 && x / 1000 % 10 == x % 100 / 10)
    {
        Console.WriteLine("число является полиндромом");
    }
    else
    {
        Console.WriteLine("число не является полиндромом");
    }
}
else
{
    Console.WriteLine("Вы не ввели пятизначное число");
}