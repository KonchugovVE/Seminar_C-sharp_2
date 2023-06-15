// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Enter(string text)
{
    System.Console.WriteLine(text);

    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool CheckingTheNum(int num)
{
    if (num < 100)
    {
        System.Console.WriteLine($"В числе {num} третьей цифры нет");
        return false;
    }
    return true;
}

int ThreeDigits(int num)
{
    while (num > 999)
    {
        num /= 10;
    }
    return num % 10;
}


int num = Enter("Введите число: ");

int number = num;

if (CheckingTheNum(num))
{
    System.Console.Write($"В числе {number} третья цифра ");
    System.Console.WriteLine(ThreeDigits(num));
}

