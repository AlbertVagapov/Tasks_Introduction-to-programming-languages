// Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран

Console.WriteLine("Введите колличество элементов в массиве: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine();

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[a];

FillArray(array);
PrintArray(array);