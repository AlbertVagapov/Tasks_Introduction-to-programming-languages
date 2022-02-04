// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите номер дня недели");
int a = int.Parse(Console.ReadLine());

if (a >= 1 && a <= 5)
{
    Console.WriteLine("Будний день");
}
else if (a >= 6 && a <= 7)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Введите число от 1 до 7");
}
