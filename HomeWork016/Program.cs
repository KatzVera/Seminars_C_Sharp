// Задача 38: Программа задает массив вещественных чисел.
// На выход находит разницу между максимальным и минимальным элементом массива.
// Пример: [3 7 22 2 78] -> 76

Console.Clear();
int[] array = new int[5];
int max = -99;
int min = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-99, 100);
    Console.Write($"{array[i]} ");

    if(array[i] > max)
    {
        max = array[i];
    }

    if(array[i] <= min)
    {
        min = array[i];
    }
}

Console.WriteLine();
Console.WriteLine($"max {max}");
Console.WriteLine($"min {min}");
Console.WriteLine($"Разнича между максимальныи и минимальным элементами массива = {max - min}");

