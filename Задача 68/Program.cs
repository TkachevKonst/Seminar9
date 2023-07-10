// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;
using static System.Console;
Clear();
Write("Введите первое число:");
int numberM = int.Parse(ReadLine());
Write("Введите второе число:");
int numberN = int.Parse(ReadLine());
WriteLine($"Функция Аккермана от чисел {numberM} и {numberN}  = {FuncAkkermana(numberM,numberN)}");

int FuncAkkermana (int num1, int num2)
{
if (num1 == 0)
{
    return num2+1;
}
if (num2 == 0)
{
    return FuncAkkermana (num1-1, 1);
}
return FuncAkkermana(num1-1,FuncAkkermana(num1,num2-1));
}
