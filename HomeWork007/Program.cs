// Задача 15: Программа на вход принимает цифру, обозначающую день недели и проверяет выходной это день или нет.
// Пример: 6 -> да: 7 -> да; 1 -> нет.

Console.Clear();
Console.WriteLine("Введите цифру дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 6)
{
    Console.WriteLine("будний день");
}
else if (n == 6 || n == 7)
{
    Console.WriteLine("выходной, ура");
}