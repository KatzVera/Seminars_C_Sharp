// Массивы

string f1 = "Anna";
string f2 = "Bob";
string f3 = "Alex";
string f4 = "Ira";
string f5 = "Mila";

// string [] f; - создание массива F типа данных string
//     имя
//   массива   0   1   2    3     4
string[] f = {f1, f2, f3, "Ira", f5};

// int[] num; - создание массива NUM типа данных int

// int[] num = new int[5]; // если массив не заполнить, он по умолчанию будет заполнен "0"
int[] num = {5, 3, 7, 1, 9};

Console.WriteLine(f[4]);

Console.WriteLine(f[1]);

f[1] = "Roman";
Console.WriteLine(f[1]);

Console.WriteLine(f.Length); // f.length - показать длинну массива

for (int i = 0; i < f.Length; i++)
{
    Console.WriteLine(f[i]);
}

/* foreach (int n in num)
{
    Console.WriteLine(n);
} */

foreach (string n in f)
{
    if (n != "Ira")
    {
        Console.WriteLine(n);
    }
}

