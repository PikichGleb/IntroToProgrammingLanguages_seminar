//6.Написать программу вычисления значения функции y = sin(a). (Класс Math)

//double x = 3.14;

double x = Math.PI;
double y = Math.Sin(x);
double y1 = Math.Sin(x * 2);

//Console.WriteLine(y);

Console.WriteLine($"{y:F16}"); //F - фиксированнаое количество знаков после запятой

Console.WriteLine(1.0 / 10000000.0);

if (y == 0) Console.WriteLine("OK");
else Console.WriteLine("Wrong");

if (y <= 1E-10) Console.WriteLine("OK");
else Console.WriteLine("Wrong");

if (Math.Abs(y - y1) <= 1E-10) Console.WriteLine("OK");
else Console.WriteLine("Wrong");