﻿// Задача 3: Программа на вход число от 1 до 7. На выход соответствующий числу день недели.

Console.Clear();
Console.Write("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n < 1 || n > 7) // [1, 7]
{
    Console.Write("Вы ошиблись! Введите день недели: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1) // Всегда проверка условия начинается с if !!!
    Console.WriteLine("Понедельник");
else if (n == 2)
    Console.WriteLine("Вторник");
else if (n == 3)
    Console.WriteLine("Среда");
else if (n == 4)
    Console.WriteLine("Четверг");
else if (n == 5)
    Console.WriteLine("Пятница");
else if (n == 6)
    Console.WriteLine("Суббота");
else if (n == 7)
    Console.WriteLine("Воскресенье");
