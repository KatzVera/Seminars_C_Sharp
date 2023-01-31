// Задача 42: Программа преобразовывает десятичное число в двоичное.
// Пример: 45 -> 101101; 3 -> 11; 2 -> 10.

Console.Clear();
Console.WriteLine("Введите число: ");
/*
string n = Console.ReadLine();
int from = 10; // из какой системы исчисления
int to = 2; // в какую систему исчисления

string binary = Convert.ToString(Convert.ToInt32(n, from), to);
Console.WriteLine(binary);
*/

int n = Convert.ToInt32(Console.ReadLine());
string res = "";

while (n > 0)
{
    res = Convert.ToString(n % 2) + res; // при строках в такой последовательности сложения строка записывает нужную последовательнлсть
    n /= 2; // n = n / 2
}

Console.WriteLine(res);



