// Задача 47: Программа задаем двумерный массив размеров M x N и заполняет его случайными вещественными числами.
// Пример: m = 3 n = 4
//         0,5 7 -2 -0,2
//         1 -3,3 8 -9,9
//         8 7,8 -7,1 9

Console.Clear();
Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];
Random random = new Random();
 for (int i = 0; i < array.GetLength(0); i++)
 {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        // array[i,j] = random.NextDouble(-9, 10) * 100;
        array[i, j] = Math.Round(random.Next(-99, 100)*0.1, 1);
        Console.Write($" {array[i,j]}");
    }
    Console.WriteLine();
 }
