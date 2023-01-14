// Задача 7: На вход число N. На выход последняя цифра числа N.

Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = n % 10;
Console.WriteLine($"последняя цифра числа: {i} ");

