//С клавиатуры вводятся три числа. Найти максимальное из трех чисел

Console.Write("Введите первое число :");
string? A = Console.ReadLine();
int a = Convert.ToInt32(A);

Console.Write("Введите второе число :");
string? B = Console.ReadLine();
int b = Convert.ToInt32(B);

Console.Write("Введите третие число :");
string? C = Console.ReadLine();
int c = Convert.ToInt32(C);

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine($"{max}");