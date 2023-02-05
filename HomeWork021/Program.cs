// Задача 52: Программа задает двумернуй массив из целых чисел.
//            На выход выдает среднее арифметическое в каждом столбце.
// Пример: 1 4 7 2
//         5 6 2 3
//         8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[m,n];
int[] sum = new int[m];
double middle = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0, 10);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < array.GetLength(1); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
        {
            middle += array[j, i];
        }
    Console.WriteLine($"Сумма элементов {i}-го столбца = {middle / array.GetLength(0)}");
    middle = 0;
}



        


