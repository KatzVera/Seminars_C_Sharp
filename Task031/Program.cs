// Задача 40: Программа принимает на вход 3 числа и проверяет, 
//            может ли существовать треугольник с такими сторонами.
// Теорема о неравенства треугоника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Clear();
Console.WriteLine("Введите 1-е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-е число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine($"треугольник со сторонами {a}, {b}, {c} может существовать");
}
else
{
    Console.WriteLine("Такой треугольник не может существовать");
}