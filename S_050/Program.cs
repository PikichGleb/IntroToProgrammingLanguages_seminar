// 50.В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j])

int[,] arr;
arr = Create2DArray(3, 4);


Print(arr);
ReplacOpposite(arr);
Print(arr);



//Замена чётных на противоположный знак
void ReplacOpposite(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++) // Перебираем строкии 
    {
        for (int j = 0; j < a.GetLength(1); j++)  // Перебираем столбцы
        {
            if (a[i, j] % 2 == 0)
            {
                a[i, j] = -a[i, j];
            }
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