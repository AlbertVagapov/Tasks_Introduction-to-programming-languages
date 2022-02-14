// Найти сумму чисел от 1 до А

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());

int index = 0;
int sum = 0;

Console.WriteLine();
while (index <= A)
{
    sum = sum + index;
    Console.WriteLine(sum);
    index++;
}
