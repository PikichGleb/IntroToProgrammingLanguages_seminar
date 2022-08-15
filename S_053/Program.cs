// 53. Написать подпрограмму, поиска элемента в двумерном массиве, подпрограмма возвращает позицию числа. Если элемент отсутствует, подпрограмма возвращает -1.


int[,] arr;
arr = Create2DArray(3, 4);

/* 
// Проверка
arr[2,3] = 5;
Print(arr);
//
*/

int i,j;
Console.WriteLine(Find(arr,5,out i, out j));
Console.WriteLine($"i = {i} j = {j}");

//Поиск элемента в двумерном массиве
bool Find(int[,] a, int number, out int i, out int j)
{
    for (i = 0; i < a.GetLength(0); i++) // Перебираем строкии 
    {
        for (j = 0; j < a.GetLength(1); j++)  // Перебираем столбцы
        {
            if (a[i, j] == number)
            {
                return true;
            }
        }
    }
    j=-1;
    i=-1;
    return false;
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

/* 
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
}
 */