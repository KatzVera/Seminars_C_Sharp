// Задача 64: Задачате значение N. Программа выводит все натуральные числа в промежутке от N до 1.
// Пример: N = 5 -> 5 4 3 2 1
//         N = 8 -> 8 7 6 5 4 3 2 1

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void Nat (int n)
{
    if (n == 1)
    {
        Console.Write($"{n} ");
    }
    else
    {
        Console.Write($"{n} ");
        Nat(n - 1);
    } 
    
}

Nat(n);
