// Задача 54: Задайте двумерный массив. Программа упорядочивает по убыванию элементы каждой строки массива.
//            Выводит результат. Пример: 1 4 7 2        7 4 2 1 
//                                       5 9 2 3   ->   9 5 3 2
//                                       8 4 2 4        8 4 4 2

Console.Clear();
Console.Write("Введите количество строк массив: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(-9, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Массив с элементами по убыванию:");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = array.GetLength(1) - 1; k > j; k--)
        {

            if (array[i,k] > array[i,k - 1])
            {
                int buffer = array[i,k];
                array[i,k] = array[i,k - 1];
                array[i,k - 1] = buffer;
            }
        }
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}




