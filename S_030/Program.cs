// 30. Написать программу вычисления произведения чисел от 1 до N


int Digits(int N)
{
    int index = 0;
    int l = 1;
    int d = 1;
    while (index < N)
    {
        l = l*d;
        Console.WriteLine($"{l}");  //Проверка
        d++;
        index++;
    }
    return l;
}
Console.Write("Введите целое число:");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"\n{Digits(z)}");