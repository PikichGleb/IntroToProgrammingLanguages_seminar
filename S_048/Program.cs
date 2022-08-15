// 48. Показать двумерный массив размером m×n заполненный целыми случайными числами.

int[,] arr; // Объявление массива

arr = Create2DArray(3, 4); // Возможно введения диапозана генерации псевдослучайных чисел arr = Create2DArray(3, 4, 0, 100);

Print(arr);


void Print(int[,] a) // Выведение двумерного массива в консоль
{
    for (int i = 0; i < a.GetLength(0); i++) // Перебираем строкии 
    {
        for (int j = 0; j < a.GetLength(1); j++)  // Перебираем столбцы
        {
            Console.Write($"{a[i, j],4}");
        }
        Console.WriteLine();
    }
}


//1 Способ вернуть результат массива // Заполнение двумерного массива
int[,] Create2DArray(int n, int m, int min=0, int max=100)
{
    int[,] a = new int[n, m]; // Создание массива // Массив ссылочный тип
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++) // Перебираем строкии 
    {
        for (int j = 0; j < a.GetLength(1); j++)  // Перебираем столбцы
        {
            a[i, j] = random.Next(min, max+1);
        }
    }
    return a;
}



/* 
//2 Способ вернуть результат массива // Заполнение двумерного массива

Create2DArray2(4,5,out arr);

void Create2DArray2(int n, int m, out int[,] a)
{
    a = new int[n, m]; // Создание массива // Массив ссылочный тип
    Random random = new Random();
    for (int i = 0; i < args.GetLength(0); i++) // Перебираем строкии 
    {
        for (int j = 0; j< args.GetLength(1); j++) // Перебираем столбцы
        {
            a[i, j] = random.Next(0, 100);
        }
    }
}
*/