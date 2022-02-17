// Задача 34: Написать программу для замены элементов массива на противоположные.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        Console.Write(" ");
        position++;
    }
}
void PrintArray2(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(-1*col[position]);
        position++;
    }
}

int[] array = new int[10];


FillArray(array);
PrintArray(array);
Console.WriteLine();
PrintArray2(array);
