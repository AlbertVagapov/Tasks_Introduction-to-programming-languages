// Показать таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

for (int i = 0; i <= N; i++)
{
    Console.WriteLine($"{i}*{i}={i * i}");
}