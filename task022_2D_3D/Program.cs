// Найти расстояние между точками в пространстве 2D/3D. Одна точка в 2D другая в 3D.

Console.WriteLine("Введите значение x1: ");
double x1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение y1: ");
double y1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение x2: ");
double x2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение y2: ");
double y2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение z2: ");
double z2 = double.Parse(Console.ReadLine());

double L =  Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z2, 2));
Console.WriteLine(L);