// Задача 66: Задайте значения M и N. Программа находит сумму натуральных элементов в промежутке от M до N.
// Пример: M = 1 N = 15 -> 120
//         M = 4 N = 8 -> 30

Console.Write("Введите начало диапазона M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец диапазона N: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int Nat (int num2, int num1)
{
    if (num2 == num1)
        return num1;
    else
        return num2 + Nat(num2 - 1, num1); 
}

Console.WriteLine($"Сумма числе в диапазоне = {Nat(num2,num1)}");