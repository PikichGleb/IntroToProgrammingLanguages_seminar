// 22. Программа проверяет пятизначное число на палиндромом.

int a, b, c, e;
Console.WriteLine("Введите пятизначное число:  ");
a = Convert.ToInt32(Console.ReadLine());

if (a >= 9999 && a <= 100000)
{
    b = a / 10000;
    a = a % 10000;
    c = a / 1000;
    a = a % 1000;
    a = a % 100;
    e = a / 10;
    a = a % 10;

    if (b == a && c == e)
    {
        Console.WriteLine("Это число палиндром");
    }
    else
        Console.WriteLine("Это не число палиндром");

}
else
    Console.WriteLine("Ошибка!");