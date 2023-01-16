/* Задача 8: Программа на вход получается число N.
           На выход показывает все четные числа от 1 до N.
 Например: 5 -> 2, 4
           8 -> 2, 4, 6, 8.
*/

Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= n; i +=2)
{
    Console.Write($"{i}, ");
}

