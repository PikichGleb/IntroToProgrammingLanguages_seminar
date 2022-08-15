// 56.Написать программу, которая обменивает элементы первой строки и последней строки


int[,] arr;
arr = Create2DArray(3, 4);


Print(arr);
SwapLine(arr);
Print(arr);



// Обмен 1 и последней строки
void SwapLine(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++) // Перебираем строкии 
    {
        for (int j = 0; j < a.GetLength(1); j++)  // Перебираем столбцы
        {
            int temp = 0;
            temp = a[0, j];
            a[0, j] = a[a.GetLength(0) - 1, j];
            a[a.GetLength(0) - 1, j] = temp;
        }

    }
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
