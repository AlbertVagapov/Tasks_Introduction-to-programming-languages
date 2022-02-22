// В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.


double[] array = new double[10];
Random rand = new Random();

double min = 1;
double max = 0;


for (int i = 0; i < array.Length; i++)  
{
    double a = Math.Round(rand.NextDouble(), 2);
    array[i] = a;                 
}
foreach (double i in array)
    Console.Write($"{i} ");
Console.WriteLine();

foreach (double i in array)
{
    if (min >= i)
        min = i;
    if (max <= i)
        max = i;               
}
double result = max - min;
Console.WriteLine($"Максимальное число: {max} минимальное число: {min}. Разница между максимальным и минимальным числом: {result}");


