// Покажите кубы чисел, заканчивающихся на чётную цифру.

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

int cube = a * a * a;
int b = cube % 2;

if (b==0)
{
    Console.WriteLine($"куб {a} числа равен {cube} и заканчивается на четную цифру");
}
else
{
    Console.WriteLine($"куб {a} числа равен {cube} и заканчивается на нечетную цифру"); 
}