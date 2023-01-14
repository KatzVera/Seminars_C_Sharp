// Задача 7: На вход число N. На выход последняя цифра числа N.

Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for( int i = n * (-1); i <= n; i++)
    {
        Console.Write($"{i}, ");
    }
