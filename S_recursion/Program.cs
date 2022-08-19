

// Нахождение факториала с помощью рекурсии

int F(int n)
{
    if (n > 0) return F(n - 1) * n;
    else
        return 1;

}

Console.WriteLine(F(5));


