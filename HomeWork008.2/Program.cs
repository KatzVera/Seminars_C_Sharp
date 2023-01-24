// Задача 19: Программа на ввод принимает пятизначное число, и проверяет является ли оно полиндромом.
// Пример : 14212 -> no; 12821 -> yes; 23432 -> yes.

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string n = Convert.ToString(Console.ReadLine());

if (n.Reverse().SequenceEqual(n))
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
