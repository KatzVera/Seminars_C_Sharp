// Задача 48: Программа задает двумерный массив M x N, каждый элемент массива находится по формуле Amn = M + N.
//            Выводим массив на экран. 

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
        array[i,j] = i + j;
        Console.Write($" {array[i,j]}");
    }
    Console.WriteLine();
 }