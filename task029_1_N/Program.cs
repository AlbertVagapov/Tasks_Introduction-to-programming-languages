// Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

int index = 1;
int sum = 1;

Console.WriteLine();

while (index <= N)
{
    sum = sum * index;
    Console.WriteLine(sum);
    index++;
}

Console.WriteLine($"произведение чисел от 1 до N - {sum}");
// // Найти сумму чисел от 1 до А

// Console.WriteLine("Введите число A: ");
// int A = int.Parse(Console.ReadLine());

// int index = 0;
// int sum = 0;

// Console.WriteLine();
// while (index <= A)
// {
//     sum = sum + index;
//     Console.WriteLine(sum);
//     index++;
// }
