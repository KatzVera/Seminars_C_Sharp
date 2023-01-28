// Задача 28: Программа на вход принимает число N. На выход выдает произведение всех чисел от 1 до N.
// Пример: 4 -> 24; 5 -> 120.

int Factorial (int n) // метод принимающий аргумент и возвращающий значение
{
int res = 1;

    for (int i = 1; i <= n; i++)
    {
        res = res * i;
    }
    return res;
}


Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{n} -> {Factorial(n)}");