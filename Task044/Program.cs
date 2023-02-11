// Задача 69: Программа принимает на вход числа A и B. На выход возводит число A в степень B.
// Пример: A = 3, B = 5 -> 243 (3 в степень 5)
//         A = 2; B = 3 -> 8

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа А: ");
int b = Convert.ToInt32(Console.ReadLine());

int Deg (int a, int b)
{
    if (b == 1)
        return a;
    return a * Deg(a, b - 1);
    
}
Console.WriteLine($"Результат = {Deg(a,b)}");
