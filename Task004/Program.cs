// Задача 5: На вход число N. На выход диапазон от -N до +N.
// Через цикл while.

Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = n * (-1);
while (i <= n)
{
    Console.Write($"{i}, ");
    i++; //шаг на i + 1
}
