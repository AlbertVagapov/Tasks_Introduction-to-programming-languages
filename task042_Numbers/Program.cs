//Определить сколько чисел больше 0 введено с клавиатуры

int count = 0;
while(true)
{
    Console.WriteLine("Введите целое число, для выхода введите не число: ");
    string input = Console.ReadLine();

    bool isNum = int.TryParse(input, out int chNum);
    if (isNum && chNum > 0) count++;
    else if (isNum && chNum <= 0) continue;
    else break;
}
Console.WriteLine($"Вы ввели {count} чисел больше 0");

