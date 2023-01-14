// Задача 5: На вход число N. На выход диапазон от -N до +N.
// Через цикл for.


Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for( int i = n * (-1); i <= n; i++)
    {
        Console.Write($"{i}, ");
    }
