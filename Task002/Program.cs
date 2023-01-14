// задача 1: На вход 2 числа. Проверка является ли 1е число квадратом 2го. если до, то "да", если нет - то "нет".

Console.Clear();

Console.Write("Введите число 1: ");
int N1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int N2 = Convert.ToInt32(Console.ReadLine());

if (N1 == N2 * N2)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}