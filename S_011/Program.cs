// Дано число больше 9. Вывести на экран  вторую цифру числа с конца

int number,number1;

number = new Random().Next(10, 100);
number1 = number / 10;

Console.WriteLine($"Случайное число: {number}");
Console.WriteLine($"Вторая цифра числа с конца: {number1}");


// Не уверен что это решается так 