// Задача 13: Программа на вход принимает число. На выход выводит 3ю цифру числа.
//            Если третьей цифры нет, то сообщает что ее нет.
// Пример: 645 -> 5; 78 -> третьей цифры нет; 32679 -> 6.

Console.Clear();
Console.WriteLine("Введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 99)
{
    while( n > 999)
    {
        n = n / 10;
    }

    Console.WriteLine(n % 10);
}

else
{
    Console.WriteLine($"{n} - третьей цифры нет");
}