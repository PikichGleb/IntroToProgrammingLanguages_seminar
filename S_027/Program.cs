// 25. Возведите число А в натуральную степень B используя цикл

Console.Write("Введите целое число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень B: ");
int B = Convert.ToInt32(Console.ReadLine());
int index = 0;
int l = A;
while (index < B)
{
    l = l*A;
    Console.WriteLine($" {l} ");
    index++;
}