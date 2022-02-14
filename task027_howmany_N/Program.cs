// Определить количество цифр в числе

Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine());

Console.WriteLine();

int B = (int)Math.Log10(A) + 1;

Console.WriteLine("цифр в числе - "+B);