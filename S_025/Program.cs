// 25. Вывести на экран кубы чисел от 1 до N

Console.Write("Введите целое число:");
int N = Convert.ToInt32(Console.ReadLine());
int index = 0;
int l = 1;
int d = 1;
while (index < N)
{
    l = d*d*d;
    Console.WriteLine($"{d}^3 = {l}");
    d++;
    l++;
    index++;
}