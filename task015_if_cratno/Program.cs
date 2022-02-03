// Дано число. Проверить кратно ли оно 7 и 23

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());

int cr1 = a % 7;
int cr2 = a % 23;

if (cr1 == 0 && cr2 == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("не кратно");
}