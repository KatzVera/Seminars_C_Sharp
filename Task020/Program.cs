// Методы. Желательно чтобы 1 метод выполнял 1 действие. Метод должен быть самостоятельным.

/*  void SayLang() // ";" тут не нужно!!!!!!
{
    Console.WriteLine("Привет, Python!"); // описание метода. Может быть людим: цикл, условие и т.д.
}


SayLang(); // вызов метода 

void SayLang(string lang) //метод, который принимает аргумент
{
    Console.WriteLine($"Привет, {lang}!");
}

SayLang("C#");

string lang1 = "JavaScript";
SayLang(lang1);

SayLang("PHP");

SayLang("C++");

SayLang("Python");
*/

int SumNum(int numA, int numB) // метод принимает аргументы
{
    if (numA > numB)
    {
        int result = numA - numB;
        return result; 
    }
    else
    {
        int result = numB - numA;
        return result; // возвращение результата
    }
}

int x = SumNum(2, 3);
Console.WriteLine(x);

int y = SumNum(5, 8);
Console.WriteLine(y);

Console.WriteLine(SumNum(11, 4));