// Задача 51: Программа задает двумерный массив. Находит сумму элементов главной диагонали.

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

 int num = 0;
 
 for (int i = 0; i < array.GetLength(0); i++)
 {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == j)
        {
            num += array [i,j];
        }
    }
 }
 Console.WriteLine($" Cумма диагональных элементов массива = {num}");
