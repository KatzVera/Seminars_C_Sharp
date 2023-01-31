// Задача 43: Программа находит точку пересечения 2х прямых, заданных ураснениями
//            y = k1*x+b1 и y = k2*x+b2 Значения k1, k2, b1 и b2 задает пользователь.
// Пример: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5).

Console.Clear();
Console.WriteLine("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают");
}

else if(k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}

else
{
    double x = (b2-b1)/(k1-k2);
    double y = (k1*(b2-b1))/(k1-k2)+b1;
 
    Console.WriteLine($"Пересечение в точке: ({x};{y})");
}
