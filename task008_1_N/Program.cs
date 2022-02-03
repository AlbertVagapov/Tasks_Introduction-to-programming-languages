// Показать четные числа от 1 до N
Console.WriteLine("Введите число N: ");
int maxN = int.Parse(Console.ReadLine());

int minN = 2;

while (minN <= maxN)
{

    if (minN % 2 == 0)
    {
        Console.WriteLine(minN);
    }
    minN = minN + 2;
}

