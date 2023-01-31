// Многомерные массивы. На примере двумерных.

/*
int[] nums = {1, 2, 3, 4, 5, 6, 7, 8, 9};

foreach (var item in nums)
{
    Console.Write(item);
}
*/

int[,] nums2 = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}, {0, 4, 2}}; // двумерный массив

/*
int[,] nums3 = new int[4, 3];

foreach (var item in nums2)
{
    Console.WriteLine(item);
}
*/

for (int i = 0; i < nums2.GetLength(0); i++)
{
    for (int j = 0; j < nums2.GetLength(1); j++)
    {
        Console.Write(nums2[i, j]); // если мы ходим рандомно заполнить массив, то в этом цикле.
    }

    //Console.WriteLine(nums2[i, 0]); // вывод 1 элемента в каждой строке
    Console.WriteLine(); // для перехода на новую строку, чтобы двумерный массив принял ворму таблицы
}