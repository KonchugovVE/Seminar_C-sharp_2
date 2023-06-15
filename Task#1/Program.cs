// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int Enter(string text)
{
    System.Console.WriteLine(text);

    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int num = Enter("Введите трехзначное число: ");

while (num < 100 || num > 999)
{
    System.Console.WriteLine("Ввод не корректен ");
    num = Enter("Введите трехзначное число: ");

}



int secondnum = num / 10 % 10;

System.Console.Write($"В числе {num} вторая цифра {secondnum} ");