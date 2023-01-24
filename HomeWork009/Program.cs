// Задача 21: Программа на вход приминмает координаты 2х точке по X, Y и Z.
// На выходе находит расстояние между этими точками в 3D.
// Пример: A(3, 6, 8); B(2, 1, -7) -> 15,84
//         A(7, -5, 0); B(1, -1, 9) -> 11,53

Console.Clear();
Console.WriteLine("Введите координату x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

Console.Write($"Рассточние между точков А({x1}, {y1}, {z1}) и точкой B ({x2}, {y2}, {z2}) = {Math.Round(AB, 2)}");
