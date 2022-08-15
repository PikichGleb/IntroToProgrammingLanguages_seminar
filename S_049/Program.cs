// 49. Показать двумерный массив размером m×n заполненный вещественными случайными числами

double[,] arr;

arr = Create2DArray(3, 4);
Print(arr);



// Заполнение вещественными случайными числами
double[,] Create2DArray(int n, int m, double min = 0, double max = 100)                 //Вариан с int min,max:      (int n, int m, int min = 0, int max = 100)
{
    double[,] a = new double[n, m]; // Создание массива // Массив ссылочный тип
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++) // Перебираем строкии 
    {
        for (int j = 0; j < a.GetLength(1); j++)  // Перебираем столбцы
        {
            a[i, j] = random.NextDouble() * (max - min);                                 //Вариан с int min,max:     random.Next(min, max + 1) / 10.0; 
        }
    }
    return a;
}

// Выведение двумерного массива в консоль
void Print(double[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++) // Перебираем строкии 
    {
        for (int j = 0; j < a.GetLength(1); j++)  // Перебираем столбцы
        {
            Console.Write($"{a[i, j],8:F} ");
        }
        Console.WriteLine();
    }
}