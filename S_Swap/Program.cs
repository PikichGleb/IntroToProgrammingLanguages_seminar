/*
void Swap(ref int a, ref int b) // reference
{
    int t = a;
    a = b;
    b = t;
}
*/

/*
int a = 1;
int b = 2;
Console.WriteLine($"a={a} b={b}");
Swap(ref a, ref b);
Console.WriteLine($"a={a} b={b}");
*/

void Calculate(int a, int b, out int sum, out int sub)
{
    sum = a+b;
    sub = a-b;
}

//int sum =0, sub =0;
int sum , sub ;

Calculate(2,2, out sum, out sub);
Console.WriteLine(Calculate);
