// Задача: на вход число. На выход кватрат числа.

Console.Clear();
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = x * x;
Console.WriteLine($"квадрат числа {x} = {y}");
