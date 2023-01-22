// Задача 17: Программана вход принимает координаты точку (X и Y), причем X != 0 и Y != 0.
// На выходе показывает в  какой четверти плоскости находится эта точка.

Console.Clear();
Console.WriteLine("Введите координату точку X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точку Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в I четверти плоскости");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится в II четверти плоскости");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в III четверти плоскости");
}
else if (x > 0 && y <0)
{
    Console.WriteLine("Точка находится в IV четверти плоскости");
}
else
{
    Console.WriteLine("Невозможно определить четверть");
}
