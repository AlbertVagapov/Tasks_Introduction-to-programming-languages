// Найти расстояние между точками в пространстве 2D/3D

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

int L =  Convert.ToInt32(math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + z2 * z2));
Console.WriteLine(L);