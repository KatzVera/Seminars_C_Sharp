// Каскадное условие.

Console.Clear();
int a = 15;

if (a < 10)
{
    Console.WriteLine(1); // когда программа нашла выполнение условия, она прекращает рассматривать дальше
}
else if (a < 20)
{
    Console.WriteLine(2);
}
else if (a < 30)
{
    Console.WriteLine(3); // при a=15 это условие уже не проверяется
}
else
{
    Console.WriteLine(4);
}
