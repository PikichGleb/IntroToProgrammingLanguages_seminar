// 12. Дано число из  диапозона  [10, 99]. Показать наибольшую цифру числа

//Решение из 2 семинара

int a = 76;
int d1 = a / 10; // Отбрасывает с помощью делениия 2 цифру
int d2 = a % 10; // Отбрасывает с помощью деления с остатком 1 цифру 

int m = Math.Max(d1, d2); // Сравнивает первую и 2 цифру

Console.WriteLine(d1);
Console.WriteLine(d2);
Console.WriteLine(m);































// Сам не додумался. Нашёл решение в интернете и немного переделал его. Вроде бы даже понял принцеп решения (Но это не точно)
/*
int number;
number = new Random().Next(10, 99);
Console.WriteLine($"Случайное число: {number}");

int max = 0;
do max = Math.Max(max, number % 10);
while ((number /= 10) != 0) ;

Console.WriteLine($"Случайное число: {max}");
*/

//   " /= " - разделить переменную на значение и ответ присвоить этой же переменной


/*  ПЕРВОНАЧАЛЬНАЯ версия из интернета.

int n = int.Parse(Console.ReadLine());
int max = 0
do max = Math.Max(max, n % 10);
while ((n /= 10) != 0);
 
Console.WriteLine(max);


By kolorotur https://www.cyberforum.ru/csharp-beginners/thread1461151.html

*/