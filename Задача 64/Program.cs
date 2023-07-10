// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;
using static System.Console;
Clear();
Write("Введите число:");
int number = int.Parse(ReadLine());
WriteLine(NumberLine(number));


string NumberLine(int num)
{
    if (num == 1)
    {
        return "1";
    }
    return num.ToString() + ", " + NumberLine(num - 1);
}