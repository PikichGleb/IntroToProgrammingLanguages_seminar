// 54. Написать подпрограмму, которая в матрице чисел находит сумму элементов главной диагонали


int[,] arr;
arr = Create2DArray(4, 4, 0, 10);


Print(arr);
int sum = SumMainDiagonal(arr);
int sum2 = SumSideDiagonal(arr);
Console.WriteLine(sum);
Console.WriteLine(sum2);





int SumMainDiagonal(int[,] a)
{
    int sum = 0;
    for (int i = 0; i < a.GetLength(0); i++) // Перебираем строкии 
    {
        for (int j = 0; j < a.GetLength(1); j++)  // Перебираем столбцы
        {
            if (i == j)
            {
                sum += a[i, j];
            }
        }
    }
    return sum;
}

int SumSideDiagonal(int[,] a)
{
    int sum = 0;
    for (int i = 0; i < a.GetLength(0); i++) // Перебираем строкии 
    {
        for (int j = 0; j < a.GetLength(1); j++)  // Перебираем столбцы
        {
            if (i == j)
            {
                sum += a[i, (arr.GetLength(0) - i - 1)];
            }
        }
    }
    return sum;
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