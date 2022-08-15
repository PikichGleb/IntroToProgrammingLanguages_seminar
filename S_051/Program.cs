// 51. Создать подпрограмму Create2DArray(m,n), которая возвращает двумерный массив следующим правилом: Aij = i+j, 
//где i и j - индексы элементов массива, а m и n - размеры массива

int[,] arr;
arr = Create2DArray(3, 4);


Print(arr);



// Заполнение двумерного массива
int[,] Create2DArray(int n, int m, int min = 0, int max = 100)
{
    int[,] a = new int[n, m]; // Создание массива // Массив ссылочный тип
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++) // Перебираем строкии 
    {
        for (int j = 0; j < a.GetLength(1); j++)  // Перебираем столбцы
        {
            a[i, j] = i+j;
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