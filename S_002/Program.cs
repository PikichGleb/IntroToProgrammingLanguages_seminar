// По двум заданным числам проверять является ли первое квадратом второго

double a, b;
string? s = Console.ReadLine();
a = Convert.ToDouble(s);
s = Console.ReadLine();
b = Convert.ToDouble(s);


if (a*a==b)
{
    System.Console.WriteLine("b is a");
}
else
{
    System.Console.WriteLine("b is`t a");
}
if (a==b*b)
{
    System.Console.WriteLine("a is b");
}
else
{
    System.Console.WriteLine("a is`t b");
}