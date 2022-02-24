// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

void FillArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int m = 3;
int n = 3;
int[,] array = new int[m, n];
FillArr(array);
PrintArr(array);
Console.WriteLine();

int x = 0;
int y = 0;

int min = array[0, 0];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < min)
        {
            min = array[i, j];
            x = i;
            y = j;
        }
    }
}
int[,] mas = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

for ()



    Console.Write(min);