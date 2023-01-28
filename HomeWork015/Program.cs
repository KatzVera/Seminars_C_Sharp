// Задача 36: Программа задает массив из случайных чисел.
// На выход считает сумму чисел стоящих на нечетных позициях.

Console.Clear();
int[] array = new int[6];
int sum = 0;

Console.WriteLine("Массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(-99, 100);
    Console.Write($"{array[i]} ");
}

for (int i = 1; i < array.Length; i = i + 2)
{
    sum = sum + array[i];
}

Console.WriteLine();
Console.WriteLine($"Сумма чисел нечетных элементов = {sum}");
