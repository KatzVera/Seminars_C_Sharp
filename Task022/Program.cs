// Задача 26: Программа на вход принимает число. На выход выдает количество цифр в числе.
// Пример: 456 -> 3; 78 -> 2; 89126 -> 5.


int Count (int n)
{

int i = 0;

while (n != 0)
    {
        n = n / 10;
        i++;
    }
    return i;
}

Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"количество цифр {Count(n)}");



