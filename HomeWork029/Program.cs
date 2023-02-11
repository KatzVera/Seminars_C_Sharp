// Задача 68: Введите два числа m и n.
//            Программа вычисляет функции Аккермана с помощью рекурсии для двух чисел.
// Пример: m = 2 n = 3 -> A(m,n) = 29
//         n = 3 m = 2 -> A(m,n) = 9

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

int Ack(int n, int m)
{
    while (n != 0)
    {

        if (m == 0)
            m = 1;
        else
            m = Ack(n, m - 1);

        n--;
    }
    return m + 1;

}
Console.WriteLine($"Результат = {Ack(n, m)}");
