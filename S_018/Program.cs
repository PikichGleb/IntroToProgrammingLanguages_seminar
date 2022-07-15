// 18. По двум заданным числам проверять является ли одно квадратом другого. Используйте подпрограмму


/*Пример: Сумма 2 чисел.
//Сумма 2 чисел.
int Sum(int a, int b)
{
    //Тело подпрограммы
    return a + b;
}

void Pause()
{
    Console.ReadKey();
}

int s = Sum(2, 2); //Вызов подпрограммы

Pause(); //Вызов подпрограммы
*/

bool Check(int a, int b)
{
    return a * a == b || b * b == a;
}

int a = 4, b = 9;

if (Check(a, b))
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine("Не является");
}