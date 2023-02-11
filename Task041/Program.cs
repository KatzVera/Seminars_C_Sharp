// Задача 63: задайте значение N. Программа выдает все натуральные числа от 1 до N.
// Пример: N = 5 -> 1 2 3 4 5;
//         N = 6 -> 6 5 4 3 2 1;


//Возвращаемый метод
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Nat (int num)
{
    Console.Write($"{num} ");
    if (num == 1)
        return 1;
    return num - Nat(num - 1);
}
Console.WriteLine();
Nat(num); 

// Невозвращаемый метод:
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void Nat (int num)
{
    if (num == 1)
    {
        Console.Write($"{num} ");
    }
    else
    {
        Nat(num - 1);
        Console.Write($"{num} ");
    } 
    
}

Nat(num);
*/


