// Задача 31:

int[] array = new int[12];
int sumPos = 0;
int sumNeg = 0;

Console.WriteLine($"Длинна массива = {array.Length}");
for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(-9, 10);
    Console.Write($" {array[i]}");

    if (array[i] > 0)
    {
        sumPos = sumPos + array[i];
    }
    else if (array[i] < 0)
    {
        sumNeg = sumNeg + array[i];
    }
}
Console.WriteLine();
Console.WriteLine ($"сумма положительных элементов {sumPos}");
Console.WriteLine ($"сумма отрицательных элементов {sumNeg}");


