//  Найти кубы чисел от 1 до N

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int sum = 0;
int index = 1;

while (index <= N)
{ 
    sum = index*index*index;
    Console.WriteLine(sum);
    index++;
}