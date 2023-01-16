/* Задача 6: Программа на вход принимает числа, на выход выдает число четное или нет.
     Пример: 4 -> да; -3 -> нет; 7 -> нет.
*/

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0)
{
    Console.WriteLine($" {n} - четное");
}
else
{
    Console.WriteLine($" {n} - не четное");
}
