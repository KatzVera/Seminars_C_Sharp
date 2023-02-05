// Задача 55: Задайте двумерный массив. Программа заменяет строки на столбцы. 
//            В случае если это невозможно, программа должна вывести для пользователя сообщение.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[m,n];
int[,] array2 = new int[n,m];

for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        array1[i,j] = new Random().Next(0, 10);
        Console.Write($"{array1[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

if (array1.GetLength(0) != array1.GetLength(1))
{
    Console.WriteLine("Размер строки и слолбца не совпадает, замена невозможна");
}
else
{
    for (int j = 0; j < array1.GetLength(0); j++)
    {
        for (int i = 0; i < array1.GetLength(1); i++)
        {
            array2[j,i] = array1[i,j];
            Console.Write($"{array2[j,i]} ");
        }
        Console.WriteLine();
    }
}
