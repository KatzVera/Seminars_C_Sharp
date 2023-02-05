// Задача 50: Программа на вход принимает элементы двумерного массива.
//            а выход возвращает есть ли данный элемент в массиве или нет.
// Пример: массив 1 4 7 2
//                5 9 2 3
//                8 4 2 4
// 17 -> такого элемента в массиве нет

Console.Clear();
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

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

int result = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i,j] == num)
        {
            result = 1;
            Console.WriteLine($"Элемент {num} в массиве на позиции [{i},{j}]");
            break;
        } 
    }
}
Console.WriteLine();

if (result == 0)
{
   Console.WriteLine($"Элемента {num} нет в массиве");  
}






 
