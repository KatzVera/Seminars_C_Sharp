// Задача 32: Программа заменяет все положительные элементы массива на соответствующиие отрицательные, 
// и все отрицательные элементы на соответствующие положительные.

int[] array = new int [5];
int[] newArray = new int [5];

for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(-9, 10);
    Console.Write($" {array[i]}");
}
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    newArray[i] = array[i] * -1;
    Console.Write($" {newArray[i]}");
}

