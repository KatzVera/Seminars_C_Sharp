// Задача 10: Программа на вход принимает трехзначное число и на выходе показывает вторую цифру этого числа.
// Пример: 456 -> 5; 782 ->; 918 -> 1

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if ( n < 100 || n > 1000)
{
    Console.WriteLine("неверное число, повторите");
}
 else
{
    int a = n / 10;
    Console.WriteLine($"Вторая цифра числа {n} - {a % 10}");
}

