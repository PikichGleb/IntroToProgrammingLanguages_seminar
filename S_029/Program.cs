// 29. Подсчитать сумму цифр в числе


int SumDigits(int N)
{
    if (N == 0) return 0;
    int sum = 0;
    while (N != 0)
    {
        sum =sum + (N % 10);
        N /= 10;
    }
    return sum;
}
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumDigits(z));