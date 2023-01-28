// Задача 24: Программа принимает на вход число A. На выход сумма чисел от 1 до A.
// Пример: 7 -> 28; 4 -> 10; 8 -> 36.

Console.Clear();
Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 0; i <= a; i++)
{
    sum = sum + i;
}

Console.WriteLine($"{a} -> {sum}");