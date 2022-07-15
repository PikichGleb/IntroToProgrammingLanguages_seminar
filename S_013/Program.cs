// 13. Удалить вторую цифру целого числа введенного с клавиатуры (с начала)

int a = Convert.ToInt32(Console.ReadLine());

int d0 = a % 10;
int na = a / 100;
a = na*10+d0;

Console.WriteLine(a);