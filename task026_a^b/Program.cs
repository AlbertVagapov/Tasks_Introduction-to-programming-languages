// Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите степень B");
int B = int.Parse(Console.ReadLine());

double sum = 0;
int index = 0;
Console.WriteLine();
while (index <= B)
{
    sum = Math.Pow(A, index);    
    Console.WriteLine($"{A}^{index} = {sum}");
    index++;
}
