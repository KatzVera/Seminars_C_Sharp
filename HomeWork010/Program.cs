// Задача 23: Программа на вход принимает число N.
// На выход выдает таблицу кубов числе от 1 до N.
// Пример: 3 -> 1, 8, 27
//         5 -> 1, 8, 27, 64, 125

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
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(Math.Pow(i + 1, 3));
    }
}