// Задача 41: Пользователь вводит M чисел. Программа считает сколько чисел больше 0 ввел пользователь.
// Пример: 0, 7, 8, -2, -2 -> 2; 1, -7, 567, 89, 223 -> 3.

Console.Clear();
Console.WriteLine("Введите числа через пробел: ");
int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;

for (int i = 0; i < nums.Length; i++)
{
    if(nums[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Кол-во элементов больше 0 -> {count}");

