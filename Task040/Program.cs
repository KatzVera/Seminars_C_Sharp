// Рекурсия

//Факториал числа : n! = 1*2*3*...*n

int Factorial(int num) // ";" не надо!!!!!
{
    if(num == 1)
        return 1;
    return num * Factorial(num - 1);
}

Console.WriteLine(Factorial(5));
