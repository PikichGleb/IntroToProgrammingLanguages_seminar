// Задать массив из 8 элементов и вывести их на экран.

/* Значимые типы (value types): int,double,float,bool */

/* Ссылочные типы (reference types): string, int[], Random */

/*
int N=8;
int[] array = new int[N];
for(int i=0; i<array.Length;i++);
    a[i] = 1;
for(int i=0; i<array.Length;i++);
    Console.WriteLine(array[i]);
*/

int N = 8;
int[] a = new int[N];
for (int i = 0; i < a.Length; i++)
    a[i] = 1;
for (int i = 0; i < a.Length; i++)
    System.Console.Write(a[i] + " ");


