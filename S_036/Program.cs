// 36. Определить, присутствует ли в заданном массиве, некоторое число

int N = 3;
int[] a = new int[N];
Random random = new Random();  // Псевдослучайные числа
for (int i = 0; i < a.Length; i++)
    a[i] = random.Next(-9, 10);

int number = 4;
//a[2] = number;

//Алгоритм линейного поиска

int j = 0;
while (j < a.Length && a[j] != number) j++;
if (j == a.Length) System.Console.WriteLine("Не найдено");
else System.Console.WriteLine($"Найдено {j}");

for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i],4}"); // где 4 это расстояние межде выводимыми

//System.Console.WriteLine();

