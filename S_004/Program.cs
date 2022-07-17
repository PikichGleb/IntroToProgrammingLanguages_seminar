//4. По заданному с клавиатуры номеру дня недели вывести его название.

/*
Console.Write("Enter a number :");
string? b1 = Console.ReadLine();
if (b1 == "1") Console.WriteLine("Monday");
if (b1 == "2") Console.WriteLine("Tuesday");
if (b1 == "3") Console.WriteLine("Wednesday");
if (b1 == "4") Console.WriteLine("Thursday");
if (b1 == "5") Console.WriteLine("Friday");
if (b1 == "6") Console.WriteLine("Saturday");
if (b1 == "7") Console.WriteLine("Sunday");
else
{
    Console.WriteLine("Enter a number from 1 to 7");
}

*/


int dayOfWeek;
//dayOfWeek =Convert.ToInt32(Console.ReadLine());
dayOfWeek =int.Parse(Console.ReadLine());

switch (dayOfWeek)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    default:
        Console.WriteLine("Wrong!");
        break;
}



