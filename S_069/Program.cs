//  69. Найти сумму элементов от M до N, N и M заданы // C помощью рекурсии

int Sum(int m, int n)
{
    if(m<n) return Sum(m+1, n) +m;
    else return m;
}

Console.WriteLine(Sum(0,4));