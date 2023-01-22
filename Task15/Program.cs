using System;
using static System.Console;

Clear();

string[] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Write("Введите день недели: ");
int day = int.Parse(ReadLine());
if ((day < 1) || (day > 7))
{
    WriteLine("Введен неверный день недели!");
}
else
{
    if ((days[day - 1] == "Суббота") || (days[day - 1] == "Воскресенье"))
    {
        WriteLine("Уррра!! Выходной");
    }
    else
    {
        WriteLine("Вставай на работу!");
    }
}

