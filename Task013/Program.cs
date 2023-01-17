// Задача 14: Программа на вход принимает число и проверяет, кратно ли оно одновременно 7 и 23.
// пример: 14 -> нет; 46 -> нет; 161 -> да.

Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 7 == 0 && n % 23 == 0)
{
   Console.WriteLine($"да, {n} кратно 7 и 23"); 
}
else
{
    Console.WriteLine($"нет, {n} не кратно 7 и 23");
}
