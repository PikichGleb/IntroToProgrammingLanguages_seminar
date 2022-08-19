// 73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности 0 и 1 


int num1 = Convert.ToInt32(System.Console.ReadLine());
int num2 = Convert.ToInt32(System.Console.ReadLine());

int F(int i)
{
    if (i < 1) return num1;
    if (i == 1) return num2;
    return F(i - 1) + F(i - 2);
}

for (int i = 0; i < 10; i++)
    Console.WriteLine(F(i));