// 41. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] a = { 3.14, 5.2, 4.32 };
double max = a[0];
double min = a[0];

for (int i = 0; i < a.Length; i++)
{
    if (max < a[i]) max = a[i];
    if (min > a[i]) min = a[i];
}

double diff = max - min;

for (int i = 0; i < a.Length; i++)
    System.Console.Write($" {a[i],4}");

System.Console.WriteLine();
System.Console.WriteLine(min);
System.Console.WriteLine(max);
System.Console.WriteLine(diff);