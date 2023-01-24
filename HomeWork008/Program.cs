// Задача 19: Программа на ввод принимает пятизначное число, и проверяет является ли оно полиндромом.
// Пример : 14212 -> no; 12821 -> yes; 23432 -> yes.

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = n / 10000;
int b = n % 10000/ 1000;
int c = n % 100 / 10;
int d = n % 10;

if (n < 10000 || n > 99999)
{
    Console.WriteLine("число не пятизначное");
}
else if (a == d && b == c)
{
    Console.WriteLine($"число {n} - полиндром");
}
else
{
    Console.WriteLine($"число {n} - не полиндром");
} 
