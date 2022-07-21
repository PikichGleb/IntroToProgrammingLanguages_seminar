// 33. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

//Версия 1
int N = 8;
int[] a = new int[N];
Random random=new Random();  // Псевдослучайные числа
for (int i = 0; i < a.Length; i++)
    a[i] = random.Next(0,2);


for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i],4}"); // где 4 это расстояние межде выводимыми

//Версия 2 ( По порядку с 1 )

int C = 8;
int[] b = new int[C];
for (int i = 0; i < b.Length; i+=2)
    b[i]+= 1;

Console.WriteLine();

for (int i = 0; i < b.Length; i++)
    System.Console.Write($"{b[i],4}"); // где 4 это расстояние межде выводимыми

