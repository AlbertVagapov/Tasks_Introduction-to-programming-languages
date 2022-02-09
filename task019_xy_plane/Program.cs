// Определить номер четверти плоскости, в которой находится точка с координатами Х и У
// причем X ≠ 0 и Y ≠ 0

Console.WriteLine("Введите число x: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число y: ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("первая четверть");
}
else if (x<0 && y>0)
{
    Console.WriteLine("вторая четверть");
}
else if (x<0 && y<0)
{
    Console.WriteLine("третья четверть");
}
else 
{
    Console.WriteLine("четвертая четверть");
}