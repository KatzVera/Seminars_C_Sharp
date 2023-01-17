// Задача: Программа выводит случайное числа из отрезка [10; 99]. И выводит большую цифру этого числа.
// Пример: 78 -> 8; 12 -> 2; 85 -> 8.

Console.Clear();
int n = new Random().Next(10, 100);
Console.WriteLine(n);

if (n % 10 > n / 10)
{
    Console.WriteLine(n % 10);
}
else
{
    Console.WriteLine(n / 10);
}

