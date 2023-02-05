// Двумерные массивы.
// Задача 53: Задайте двумерный массив. На выходе программа меняет местами первую строку массива с последней. 

Console.Clear();
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
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
Console.WriteLine($"Массив после замены строки 1 и строки {m} местами");

int [] temp = new int [array.GetLength(1)]; // одномерный массив как буфер обмена для строки двумерного массива

for (int k = 0; k < array.GetLength(1); k++)
{
    temp[k] = array[0,k]; // запись 1й строки во временный массив
    array[0,k] = array[m-1,k]; // запись последней строки в первую
    array[m-1,k] = temp[k]; // запись первой строки в последнюю
}

for (int i = 0; i < array.GetLength(0); i++) // вывод двумерного массива с изменениями
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}

