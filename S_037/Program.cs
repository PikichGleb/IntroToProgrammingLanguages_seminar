// 37. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int N = 8;
int[] a = new int[N];
Random random = new Random();
for (int i = 0; i < a.Length; i++)
    a[i] = random.Next(100, 1000);

int index = 0;
int chet = 0;
int nechet = 0;
int c = 0;

while (index < a.Length)
{
    c = a[index] % 2;
    if (c == 0)
    {
        chet++;
    }
    else
    {
        nechet++;
    }
    index++;
}

for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i],4}");

Console.WriteLine();
Console.Write($"Кол-во чётных:{chet,4}");
Console.Write($"\nКол-во не чётных:{nechet,4}");