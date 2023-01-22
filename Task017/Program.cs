// Задача 18: Программа по заданному номеру четверти присваивает диапазон возможных координат X и Y.

Console.Clear();
Console.WriteLine("Введите новем четверти: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 1)
{
    int x = new Random().Next(1, 100000);
    int y = new Random().Next(1, 100000);
    Console.WriteLine($"координаты точки X = {x} и Y = {y}");
}
else if (n == 2)
{
    int x = new Random().Next(-100000, 0);
    int y = new Random().Next(1, 100000);
    Console.WriteLine($"координаты точки X = {x} и Y = {y}");
}
else if (n == 3)
{
    int x = new Random().Next(-100000, 0);
    int y = new Random().Next(-100000, 0);
    Console.WriteLine($"координаты точки X = {x} и Y = {y}");
}
else if(n == 4)
{
    int x = new Random().Next(1, 100000);
    int y = new Random().Next(-100000, 0);
    Console.WriteLine($"координаты точки X = {x} и Y = {y}");
}