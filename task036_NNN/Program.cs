//Задать массив, заполнить случайными положительными трёхзначными числами.
//Показать количество нечетных и четных чисел

int[] array;
array = new int[10];
Random rnd = new Random();
int chet = 0;
int nechet = 0;

for (int i = 0; i < array.Length; i++)
{
    int number = rnd.Next(100, 1000);
    array[i] = number;
}
foreach (int i in array)  // для каждого индекса в массиве
Console.Write($"{i} ");

Console.WriteLine();
foreach (int i in array)
if (i % 2 == 0)
chet += 1;
else nechet += 1;
Console.WriteLine($"Количество четных чисел равно: {chet}");
Console.WriteLine($"Количество нечетных чисел равно: {nechet}");

