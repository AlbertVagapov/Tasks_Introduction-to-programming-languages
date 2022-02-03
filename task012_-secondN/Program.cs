// Удалить вторую цифру трёхзначного числа.

Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());

if (a > 99 && a < 999)
{
    int n1 = a / 100;
    //int n2 = a % 100 / 10;
    int n3 = a % 10;
    int z1 = n1 * 10;
    int result = z1 + n3;
    Console.WriteLine("Результат без второй цифры: " + result);
}
else
{
    Console.WriteLine("Вы не ввели трехзначное число");
}