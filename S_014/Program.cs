// 14. С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

int a, b, dev;

string? a1, b1;

double dev1;

Console.WriteLine("Введите a:");
a1 = Console.ReadLine();
a = Convert.ToInt32(a1);

Console.WriteLine("Введите b:");
b1 = Console.ReadLine();
b = Convert.ToInt32(b1);

dev = a % b;

if (dev == 0)
{
    Console.WriteLine($"Число {a} кратно числу {b} ");
}
else
{
    dev1 = a % b;
    Console.WriteLine($"Остаток от деления {dev1} ");
}