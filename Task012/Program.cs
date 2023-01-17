// Задача 12: Программа примимает на вход 2 числа. На выход определяет является ли 2е число кратным 1му и выводит остаток.
// Пример: 34, 5 -> не кратно, остаток 4
//         16, 4 -> кратно.

Console.Clear();
Console.WriteLine("Введите 1-е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = a % b; // a % b число "a" кратно числу "b" т.е. остаток равен "0"

if (c == 0) // можно минуя "C" сразу в условии написать (a % b)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine($"не кратно, остаток {c}");
}
