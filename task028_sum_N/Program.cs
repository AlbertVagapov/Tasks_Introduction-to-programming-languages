// Подсчитайте сумму цифр в числе.
//A.ToString().Length

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int s = 0;
while (a > 0)
{
    s = s + a % 10;
    a = a / 10;
}
Console.WriteLine("сумма цифр в числе - " + s);
