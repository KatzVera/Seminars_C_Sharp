﻿// Задача со сложным условием.

Console.Clear();
int a =5;
int b = 23;

if (a > 10 && b > 20 || a > 5) // При "&&" означает "И". Если одна из частей условея лохная, все условие ложное.
{                               // При "||" означает "ИЛИ". Если одно из условий истина, то все условие истина.
    Console.WriteLine(1);
}
else
{
    Console.WriteLine(2);
}