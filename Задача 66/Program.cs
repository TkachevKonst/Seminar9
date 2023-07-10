// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


using System;
using static System.Console;
Clear();
Write("Введите первое число:");
int numberM = int.Parse(ReadLine());
Write("Введите второе число:");
int numberN = int.Parse(ReadLine());
WriteLine ($"Сумма чисел от {numberM} до {numberN} = {SumLineNumber(numberM,numberN)}");

int SumLineNumber (int num1, int num2)
{
if (num1 == num2)
{
    return num2;
}
return num1 + SumLineNumber(num1+1, num2);
}