// Задача 67: Программа на вход принимает число. Возвращает сумму всех цифр числа.
// Пример: 453 -> 12
//         45 -> 9

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Summ (int num)
{
    if (num == 0)
        return num;
    return num % 10 + Summ(num / 10);
    
}
Console.WriteLine($"Сумма цифр числа: {Summ(num)}");

