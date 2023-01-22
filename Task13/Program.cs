using System;
using static System.Console;

Clear();

Write("Введите число: ");
int number = int.Parse(ReadLine());
if ((number < 100) & (number > -99))
WriteLine("Третьей цифры нет!");
else
{
    while ((number >= 999) || ((number < -99) & (number <= -999)))
    {
        number = number / 10;
    }
    WriteLine($"{Math.Abs(number % 10)}");
}