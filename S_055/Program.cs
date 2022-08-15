// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.


int[,] arr;
arr = Create2DArray(3, 4, 0, 10);


Print(arr);
double arithmeticMean = ArithmeticMean(arr);


double ArithmeticMean(int[,] a)
{
    double s = 0;
    double d = 0;
    for (int i = 0; i < a.GetLength(1); i++) 

    {
        for (int j = 0; j < a.GetLength(0); j++)  
        {
            s =(s+ a[j, i]);
            Console.WriteLine(s);
        }
        d =s / a.GetLength(1);
        Console.WriteLine(d);
        
    }
    return s;
}

// Заполнение двумерного массива
int[,] Create2DArray(int n, int m, int min = 0, int max = 100)
{
    int[,] a = new int[n, m]; // Создание массива // Массив ссылочный тип
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++) // Перебираем строкии 
    {
        for (int j = 0; j < a.GetLength(1); j++)  // Перебираем столбцы
        {
            a[i, j] = random.Next(min, max + 1);
        }
    }
    return a;
}

// Выведение двумерного массива в консоль
void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++) // Перебираем строкии 
    {
        for (int j = 0; j < a.GetLength(1); j++)  // Перебираем столбцы
        {
            Console.Write($"{a[i, j],4}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
