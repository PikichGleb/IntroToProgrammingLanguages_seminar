// 17. Дано число обозначающее день недели. Выяснить является номер дня недели выходным


int a = 7;
bool b = a == 6 || a == 7;
if (b == true)                      //if (a == 6 || a == 7)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine(" Не является выходным!");
}
























/*
int dayOfWeek;
//dayOfWeek =Convert.ToInt32(Console.ReadLine());
dayOfWeek =int.Parse(Console.ReadLine());

switch (dayOfWeek)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;   
    case 7:
        Console.WriteLine("Воскресенье");
        break;
    default:
        Console.WriteLine("Ошибка!");
        break;
}

*/