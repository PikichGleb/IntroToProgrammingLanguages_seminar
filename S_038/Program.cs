// 38. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

// Не уверен что правильно понял условия задачи !

int N = 123;
int[] a = new int[N];
Random random=new Random();  
int quantity = 0;
for (int i = 0; i < a.Length; i++)
{    
    a[i] = random.Next(0,1000);
    if(a[i]>10 && a[i]<100){
        quantity = quantity+1;
    }

}


for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i],4}");

System.Console.WriteLine();
System.Console.Write($"Количество элементов из отрезка [10,99]: {quantity}");
