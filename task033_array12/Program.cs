// Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива

int[] array = new int [12];
int sum_plus = 0,
    sum_minus = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);

    if (array[i] > 0)
        sum_plus += array[i];
    else
        sum_minus += array[i];
}

Console.WriteLine(sum_plus);
Console.WriteLine(sum_minus);

