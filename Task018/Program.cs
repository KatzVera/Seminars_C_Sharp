// Задача 21: Программа принимает на вход координаты 2х точек и находит расстояние между ними в 2D пространстве.
// Пример : A(3,6); B(2,1) -> 5,09
//          A(7,-5); B(1,-1) -> 7,21

Console.Clear();
Console.WriteLine("Введите координату x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

Console.Write($"Рассточние между точков А({x1}, {y1}) и точкой B ({x2}, {y2}) = {Math.Round(AB, 2)}");

