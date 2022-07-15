// 28. Определить количество цифр в числе. Сделать подпрограмму.

int CountDigits(int N)
{
    if(N==0) return 1;
    int k = 0;
    while (N != 0)
    {
        k++;
        N/=10;
    }
    return k;
}

Console.WriteLine(CountDigits(0));











/*
int N = 13214;
int k = 0;
while (N != 0)
{
    k++;
    //N = N /10;
    N/=10;
}
Console.WriteLine(k);
*/