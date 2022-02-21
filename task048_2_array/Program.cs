// Показать двумерный массив размером m×n заполненный целыми числами
Console.WriteLine("Введите число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]}");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 100) ; // заполняем числами [0,100)
        }
    }
}
int[,] array = new int[m,n];
FillArray(array);
PrintArray(array);


