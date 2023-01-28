// Задача 33: Программа определяет присутстует ли в массиве заданное число.

int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(-9, 20);
    Console.Write($" {array[i]}");
}

Console.WriteLine();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int z = 0;

for (int j = 0; j < array.Length; j++)
{
    if (array[j] == n)
    {
        z = 1;
    }

}
if (z ==1)
{
    Console.WriteLine("в массиве есть такое число");
}
else if (z == 0)
{
    Console.WriteLine("в массиве нет такого числа");
}


    


