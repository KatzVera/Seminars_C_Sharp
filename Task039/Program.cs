// Задача 57: Программа составляет частотный словарь элементов массива (двумерного массива).
//            Частотный словарь содержит информацию о том, сколько раз встречается данный элемент.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимум рандома: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0, max);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int num = 0;

while (num < max)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == num)
            {
                count ++;
            }
        }
    }

    if (count == 0)
    {
        Console.WriteLine($"Число {num} в матрице не встречается");
    }
    else
    {
        Console.WriteLine($"Число {num} встречается в матрице - {count} раз");
    }

    num ++;
}