/* Задача 2: Программа на вход принимает два числа. 
           На выход выводит, какое число больше, а какое число меньше.
   Пример: a = 5; b = 7 -> max = 7
           a = 2; b = 10 -> max = 10
           a = -9; b= -3 -> max = -3
*/

Console.Clear();
Console.Write("Введите 1-е число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a < b)
{
    Console.WriteLine($"max = {b}");
}
else
{
    Console.WriteLine($"max = {a}");
}
