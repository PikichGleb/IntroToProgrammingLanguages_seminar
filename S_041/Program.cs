// 41. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом


/*

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

*/



//using System;

double[] a;
double min, max;
InitDoubles(out a, 2);
//string s = Console.ReadLine();                              // Ввод масива
//string [] ss = s.Split(' ');                                //.Split Разбивает строку на подстроки на основе указанного символа-разделителя и, необязательно, параметров.
//a=Array.ConvertAll<string,double>(ss,Convert.ToDouble);     // Конвертация массива

FindMinMax(a, out min, out max);
Print(a);
System.Console.WriteLine();
System.Console.WriteLine(max - min);


void InitDoubles(out double[] a, int Length = 8, int min = 0, int max = 100) 
{
    a = new double[Length];
    Random random = new Random();
    for (int i = 0; i < a.Length; i++)
        a[i] = random.Next(min, max + 1) / 10.0;
}

void FindMinMax(double[] a, out double min, out double max)
{
    min = a[0];
    max = a[0];
    for (int i = 1; i < a.Length; i++)
    {
        if (a[i] > max) max = a[i];
        if (a[i] < min) min = a[i];
    }
}


void Print(double[] a)
{
    for (int i = 0; i < a.Length; i++)
        System.Console.Write($"{a[i],4}");
}