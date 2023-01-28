// Задача 25: Программа принимает на вход числа A и B. На выход возводит A в натуральную степень B (циклом).
// пример: 3, 5 -> 243; 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = a;

for (int i = 0; i < b - 1; i++)
{
    c = c * a;
}

Console.WriteLine($"Число {a} в степени {b} = {c}");
