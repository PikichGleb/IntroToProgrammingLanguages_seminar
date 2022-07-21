// Задать массив из 8 элементов и вывести их на экран.

/* Значимые типы (value types): int,double,float,bool */

/* Ссылочные типы (reference types): string, int[], Random */

/*
int N=8;
int[] array = new int[N];
for(int i=0; i<array.Length;i++)
    array[i] = 1;
for(int i=0; i<array.Length;i++)
    Console.Write(array[i] + " ");
*/


/*
int N = 8;
int[] a = new int[N];
for (int i = 0; i < a.Length; i++)
    a[i] = 1;
for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i],4}"); // где 4 это расстояние межде выводимыми

*/

int N = 8;
int[] a = new int[N];
Random random=new Random();  // Псевдослучайные чилса
for (int i = 0; i < a.Length; i++)
    a[i] = random.Next(0,100);
for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i],4}"); // где 4 это расстояние межде выводимыми


