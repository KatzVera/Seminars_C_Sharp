/* Задача 4: Программа на вход принимает 3 числа.
             На выход выдает максимальное из этих чисел.
   Пример: 2, 3, 7 -> 7
           44, 5, 78 -> 78
           22, 3, 9 -> 22
*/

Console.Clear();
Console.Write("Введите 1-е число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 3-е число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if ( a > max) max = a;
if ( b > max) max = b;
if ( c > max) max = c;

Console.WriteLine (max);