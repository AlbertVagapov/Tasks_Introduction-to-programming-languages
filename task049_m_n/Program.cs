// Показать двумерный массив размером m×n, заполненный вещественными числами

Console.WriteLine("Введите число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write("{0,6:F2}", matr[i, j]);
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Random rand = new Random();

            matr[i, j] = rand.NextDouble()*100;
        }
    }
}
double[,] array = new double[m,n];
FillArray(array);
PrintArray(array);
