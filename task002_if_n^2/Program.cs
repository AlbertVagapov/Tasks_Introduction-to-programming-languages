// По двум заданным числам a и b проверять является ли первое квадратом второго

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());

if(a == b * b)
{
    Console.WriteLine("a = b^2: ");
} 
else
{
    Console.WriteLine("a не равняется b^2: ");
}