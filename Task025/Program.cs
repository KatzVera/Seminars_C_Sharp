// Строки

/*
string s = "Hello World!"; // строка неизменяемый тип данных. Нельзя менять отдельно 1 символ.
string s1 = "Hello";
string s2 = "World!";

int[] nums = {1, 2, 3, 4, 5};

string s3 = s1 + " " + s2;

string s4 = string.Concat(s1, s2);

string s5 = string.Join(" ", nums); // объединяет элементы коллекции nums

string s7 = "1, 2, 3, 4, 5, 6, 7";

foreach (var item in s7)
{
    Console.WriteLine(item);
}

// Console.WriteLine(s5);
*/

string s7 = "1, 2, 3, 4, 5, 6, 7.";

string[] subs = s7.Split(new char[]{' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries); // split ищет символ в строке и разбивает на до него и после

int [] n = subs.Select(Int32.Parse).ToArray(); // создаем массив чисел из набора строк
foreach (var item in subs)
{
    Console.WriteLine(item);
}

string s = "10 21 35 45 57 68 79";
int[] num1 = Array.ConvertAll(s.Split(), int.Parse);