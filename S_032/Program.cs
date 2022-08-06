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

/*

//Ввод данных
int N = 8;
int[] a = new int[N];
Random random=new Random();  // Псевдослучайные чилса


for (int i = 0; i < a.Length; i++)
    a[i] = random.Next(0,100);

//Обработка данных


//Вывод результатов
for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i],4}"); // где 4 это расстояние межде выводимыми


*/



// Инициализация переменных
int[] a;


//Ввод данных
Init(out a,max:100);


//Обработка данных


//Вывод результатов
Print(a);


void Init(out int[] a, int Length =8, int min =0, int max=10) //min= 0, - аргумент по умолчанию
{
    a = new int[Length];
    Random random = new Random();
    for (int i = 0; i < a.Length; i++)
        a[i] = random.Next(min, max+1);
}


void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
        System.Console.Write($"{a[i],4}");
}