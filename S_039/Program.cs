﻿// 39. Найти сумму чисел одномерного массива стоящих на нечетной позиции

int N = 8;
int[] a = new int[N];
Random random = new Random();  // Псевдослучайные числа
for (int i = 0; i < a.Length; i++)
    a[i] = random.Next(0, 11);




for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i],4}"); // где 4 это расстояние межде выводимыми

int sum = 0;
for (int i = 1; i < a.Length; i += 2)
    sum += a[i];

Console.WriteLine($"\n{sum,4}");