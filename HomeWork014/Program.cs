// Задача 34: Программа заполняет массив случайными трехзначными числами.
// На выход выдает массив и количество четных чисел в массиве.
// Пример: [345, 897, 568, 234] -> 2

Console.Clear();
int[] array = new int[5];
int a = 0;

Console.WriteLine("Массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(100, 1000);
    Console.Write($"{array[i]} ");

    if (array[i] % 2 == 0)
        {
            a = a + 1;
        }
}
 Console.WriteLine();
 Console.WriteLine($"четных чисел в массиве - {a}");


