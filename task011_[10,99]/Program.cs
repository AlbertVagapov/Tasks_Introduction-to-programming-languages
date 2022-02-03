// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.WriteLine("Введите число от 10 до 99: ");
int a = int.Parse(Console.ReadLine());

int b = a % 10;

int c = (a - b) / 10;

int d = a / 10;


Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);