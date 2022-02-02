// Даны два числа. Показать большее и меньшее число

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());

if(a>b)
{
    Console.WriteLine("a больше b");
}
else if(a==b)
{
    Console.WriteLine("a равно b");
}
else
{
    Console.WriteLine("a меньшне b");
}