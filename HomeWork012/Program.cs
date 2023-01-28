// Задача 27: Программа на вход принимает число. На выход выдает сумму цифр числа.
// Пример: 452 -> 11; 82 -> 10; 9012 -> 12.

Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"количество цифр {Count(n)}");
int a = 0;
int b = n % 10;

while (n != 0)
{
    n = n / 10;
    a = n % 10;
    b = b + a; 
}

Console.WriteLine($"сумма цифр числа = {b}");
