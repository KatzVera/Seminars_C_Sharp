// Задача 49: Программа задает двумерный массив. Находит элементы у которых ода индекса четные,
//            заменяет эти элементы на их квадрат.

Console.Clear();
Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
 for (int i = 0; i < array.GetLength(0); i++)
 {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(-10, 11);
        Console.Write($" {array[i,j]}");
    }
    Console.WriteLine();
 }
 Console.WriteLine();

 for (int i = 0; i < array.GetLength(0); i++) // если 0 не считает четным, то i = 1 и j = 1
 {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            array[i,j] = Convert.ToInt32(Math.Pow(array[i,j], 2));
        }
        Console.Write($" {array[i,j]}");
    }
    Console.WriteLine();
 }