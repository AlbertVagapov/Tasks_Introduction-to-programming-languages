// Определить, присутствует ли в заданном массиве, некоторое число

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine();

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
        Console.WriteLine(col[position]);
        position++;
    }
}

int Indexof(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;

        }
        index++;
    }
    return position;

}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = Indexof(array, a);
if (pos==-1)
{
    Console.WriteLine("Числа нет в массиве");    
}
else
{
    Console.WriteLine($"присутствует в {pos} позиции массива");
}
