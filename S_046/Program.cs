// 46. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1

int N =Convert.ToInt32(Console.ReadLine());
int[] array= new int[N];

array[0] = 0;
array[1] = 1;

for(int i =2;i<N;i++){
    array[i] = array[i-1] + array[i-2];
}

Print(array);




void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write($"{array[i],4}");
}