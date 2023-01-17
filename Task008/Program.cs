// Условный цикл.

Console.Clear();
int a = 5;


while (a < 10) // пока условие истина, код будет выполняться
{
    Console.WriteLine(a); 
    a++; // если цикл бесконечный, прервать его можно ctrl + C
    break;
}
Console.WriteLine("OK");

