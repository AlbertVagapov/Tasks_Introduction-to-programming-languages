// По двум заданным числам проверять является ли одно квадратом другого

//int a = new Random().Next(1, 99);
//int b = new Random().Next(1, 99);

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());

if (a == b * b | b == a * a)
{
    Console.WriteLine("число является квадратом другого");
}
else
{
    Console.WriteLine("число не является квадратом другого");
}