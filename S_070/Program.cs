// 70. Найти сумму цифр числа. C помощью рекурсии


int Sum(int n)
{
    if (n == 0) return 0;
    else
        return n % 10 + Sum(n / 10);

}
System.Console.WriteLine(Sum(105));