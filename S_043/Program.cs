// 43. С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры



Console.ReadLine();
string s = Console.ReadLine();
string[] ss = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int[] a = Array.ConvertAll<string, int>(ss, int.Parse);
int k = 0;
for (int i = 0; i < a.Length; i++)
{
    if (a[i] > 0)
        k++;
}
Console.Write(k);