// Задача 11: Программа выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// Пример: 456 -> 46; 782 -> 72; 918 -> 98.

Console.Clear();
int n = new Random().Next(100, 1000);

Console.WriteLine($"рандомное число - {n}");

Console.Write(n/100);
Console.WriteLine(n%10);
