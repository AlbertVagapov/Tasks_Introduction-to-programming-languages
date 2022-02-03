// Показать вторую цифру трёхзначного числа.

Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());

if (a > 100 && a < 999)
{
    int b = a % 100 / 10;
    Console.WriteLine("вторая цифра: " + b);
}
else
{
    Console.WriteLine("Вы не ввели трехзначное число");
}
