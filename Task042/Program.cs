// Задача 65: задайте значения M и N. Программа выдает все натуральные числа от M до N.
// Пример: M = 1 N = 5 -> 1 2 3 4 5
//         M = 4 N = 8 -> 4 5 6 7 8 

Console.Write("Введите начало диапазона N: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец диапазона M: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int Nat (int num2, int num1)
{
    Console.Write($"{num2} ");
    if (num2 == num1)
        return num1;
    return num2 - Nat(num2 - 1, num1); 
}
Console.WriteLine();
Nat(num2,num1);
