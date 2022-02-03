// Найти максимальное из трех чисел
Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число c: ");
int c = int.Parse(Console.ReadLine());

if(a >= b && a >= c)
{
    Console.WriteLine("Nubmer Max = " + a); 
}
else if(b >= a && b >= c)
{
    Console.WriteLine("Number Max = " + b);
}
else
{
    Console.WriteLine("Number Max = " + c);
}
