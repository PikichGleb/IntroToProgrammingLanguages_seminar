// 10.Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 

Console.WriteLine("Введите число:");
string? N = Console.ReadLine();
int number = Convert.ToInt32(N);

Console.WriteLine(number%10);