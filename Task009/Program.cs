// Цикл с условтем. Прекращение цикла с условием.

Console.Clear();
int a = 5;


while (a < 10)
{
    
    a++; 
    Console.WriteLine(a);
    
    if (a == 8)
    {
       Console.WriteLine("111");
       break; 
    }
    
}
Console.WriteLine("OK");

