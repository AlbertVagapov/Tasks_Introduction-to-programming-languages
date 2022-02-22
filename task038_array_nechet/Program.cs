// Найти сумму чисел одномерного массива, стоящих на нечётной позиции.

int[] array = new int[6];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write(array[i]);
    Console.Write(" ");
    if (i % 2 == 1)
    {
        sum += array[i];
    }
}
Console.WriteLine();
Console.WriteLine(sum);