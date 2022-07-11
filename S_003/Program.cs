//С клавиатуры вводятся два числа a и b. Найти максимальное из них.

Console.Write("Введите число a:");
string? c = Console.ReadLine();
int a = Convert.ToInt32(c);

Console.Write("Введите число b:");
string? d = Console.ReadLine();
int b = Convert.ToInt32(d);

int max = a;

if (a > b) max = a;
if (b > a) max = b;

Console.Write($"Максимальное число : {max}");