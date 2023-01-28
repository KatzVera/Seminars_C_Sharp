// Задача 29: Программа которая задает массив из 8 элементов и выводит их на экран.
// Пример: 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]; 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int[] array = new int[8];

Console.WriteLine($"Длинна массива = {array.Length}");
for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(-20, 20);
    Console.Write($" {array[i]}");
}
