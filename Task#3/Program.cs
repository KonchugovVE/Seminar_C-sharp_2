// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


int Enter(string text)
{
    System.Console.WriteLine(text);

    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool Check(int day)
{
    if (day > 7)
    {
        System.Console.WriteLine("\nНе верный ввод, неделя состоит из 7 дней!\n");
        return false;
    }
    return true;
}

bool DayOff(int day)
{
    if (day > 6)
    {
        return true;

    }
    return false;
}

int day = Enter("\nВведите день недели:\n");

if (Check(day))
{
    if (DayOff(day))
    {
        System.Console.WriteLine($"\n{day} день недели является выходным\n");
        return;

    }
    else
    {
        System.Console.WriteLine($"\n{day} день недели не является выходным\n");
    }
}