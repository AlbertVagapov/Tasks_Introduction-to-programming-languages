// Выяснить является ли число чётным

Console.WriteLine("Введите число a: ");

int a = int.Parse(Console.ReadLine());

if(a % 2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}