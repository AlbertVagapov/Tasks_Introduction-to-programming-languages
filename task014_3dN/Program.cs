// Найти третью цифру числа или сообщить, что её нет.

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(n>99 ? n.ToString()[2] : "Введте число большее 99");
