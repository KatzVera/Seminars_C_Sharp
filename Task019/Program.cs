// Задача 22: Программа на вход принимает число N.
// На выход выдает таблицу квадратов числе от 1 до N.
// Пример: 5 -> 1, 4, 6, 16, 25;
//         2 -> 1, 4;

Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (n <= 0)
{
    Console.WriteLine("Неверное число, введите положительное число");
}
else if (n > 0)
{
    for (int i = 1; i <= n; i++) // for (int i = 0; i < n; i ++)
    {
        Console.WriteLine(Math.Pow(i, 2)); // Console.WriteLine(Math.Pow(i+1, 2))
    }
}

