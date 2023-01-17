// Счетный цикл.

Console.Clear();
int a = 5;

for (int i =0; i < 10; i++)
{
    if(i == 8 || i == 7)
    {
        continue;
        Console.WriteLine("111");
    }
    Console.WriteLine(i);
}

Console.WriteLine("OK");

