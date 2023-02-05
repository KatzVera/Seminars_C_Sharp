// Двумерные массивы
//Задача 46: Программа задает двумерный массив размером M x N и заполняет его случайными целыми числами.

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
        array[i,j] = new Random().Next(-99, 100);
        Console.Write($" {array[i,j]}");
    }
    Console.WriteLine();
 }