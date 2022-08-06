// 34. Задать массив из 12 элементов, заполненных числами из [-9, 9]. Найти сумму положительных/отрицательных элементов массива

/*
int N = 12;
int[] a = new int[N];
Random random = new Random();  // Псевдослучайные числа
for (int i = 0; i < a.Length; i++)
    a[i] = random.Next(-9, 10);

int sumPositive = 0;
for (int i = 0; i < a.Length; i++)
{   
    if (a[i] > 0)
    {
        sumPositive = sumPositive + a[i];
    }
}

int sumNegative = 0;
for (int i = 0; i < a.Length; i++)
{   
    if (a[i] < 0)
    {
        sumNegative += a[i];
    }
}



for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i],4}"); // где 4 это расстояние межде выводимыми

//System.Console.WriteLine();
System.Console.WriteLine($"\nСумма положительных: {sumPositive}");
System.Console.Write($"Сумма отрицательных: {sumNegative}");
*/


int[] a;

Init(out a, 12, -9, 9);


int sumPositive,sumNegative;
Solve(a,out sumPositive, out sumNegative);


Print(a);
System.Console.WriteLine($"\nСумма положительных: {sumPositive}");
System.Console.Write($"Сумма отрицательных: {sumNegative}");



void Init(out int[] a, int Length = 8, int min = 0, int max = 10) //min= 0, - аргумент по умолчанию
{
    a = new int[Length];
    Random random = new Random();
    for (int i = 0; i < a.Length; i++)
        a[i] = random.Next(min, max + 1);
}

void Solve(int[] a, out int sumPositive, out int sumNegative)
{
    sumPositive = 0;
    sumNegative = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] > 0)
        {
            sumPositive = sumPositive + a[i];
        }


        if (a[i] < 0)
        {
            sumNegative += a[i];
        }
    }
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
        System.Console.Write($"{a[i],4}");
}