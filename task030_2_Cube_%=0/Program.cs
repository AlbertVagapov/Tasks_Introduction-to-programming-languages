// Покажите кубы чисел, заканчивающихся на чётную цифру.

Console.WriteLine("Введите до какого числа");
int number = int.Parse(Console.ReadLine());

// int b = cube % 2;
int index = 0;
int sum = 0;
int count = 1;

Console.WriteLine();

while (count <= number)
{
    sum = count * count * count;
    if (sum % 2 == 0)
    {
        Console.WriteLine($"куб от {count} равен {sum} и заканчивается на четную цифру");        
    }
    count++;
}