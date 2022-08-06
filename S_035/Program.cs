// 35. Написать программу замены элементов массива на противоположные




// Замена элемента массива на противоположный знак
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
