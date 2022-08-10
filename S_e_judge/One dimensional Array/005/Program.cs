//Вводится число N, а затем - N чисел.
//Определить, сколько среди них пар одинаковых чисел, стоящих рядом.

using System;
Console.ReadLine();
string s=Console.ReadLine();
string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[] a=Array.ConvertAll<string,int>(ss,int.Parse);

int k=0;
for(int i=0;i<a.Length-1;i++)
    if (a[i]==a[i+1])
        k++;

System.Console.WriteLine(k); 