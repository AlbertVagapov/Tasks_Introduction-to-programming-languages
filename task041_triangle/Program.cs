// Выяснить являются ли три числа сторонами треугольника

Console.WriteLine("Введ сторону a");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введ сторону b");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введ сторону c");
int c = int.Parse(Console.ReadLine());

if (a + b > c && b + c > a && c + a > b)
{
    Console.WriteLine("три числа являются сторонами треугольника");    
}
else
{
    Console.WriteLine("три числа не являются сторонами треугольника");       
}
