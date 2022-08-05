// 35. Написать программу замены элементов массива на противоположные


?   Кажется не понял условия  задачи

/* // Замена элемента массива на противоположный знак
int N = 8;
int[] a = new int[N];
Random random=new Random();  // Псевдослучайные чилса
for (int i = 0; i < a.Length; i++)
   { 
    a[i] = random.Next(-100,100);
    a[i]*=-1;
   }
for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i],4}"); // где 4 это расстояние межде выводимыми
*/



/*














// Сортировка
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

*/