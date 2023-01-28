// Задача 30: Программа выводит масси из 8 элементов, заполняемый 0 и 1 в случайном порядке.
// Пример: [1, 0, 1, 1, 0, 1, 0, 0].

int[] array = new int[8];
Console.WriteLine($"Длинна массива = {array.Length}");
for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(0, 2);
    Console.Write($" {array[i]}");
}

