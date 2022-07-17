// 26. Найти сумму чисел от 1 до А

Console.Write("Введите целое число:");
int N = Convert.ToInt32(Console.ReadLine());
int index = 0;
int l = 0;
int d = 1;
while (index < N)
{
    l = l+d;
    Console.WriteLine($"{l}");
    d++;
    index++;
}