// Задача 71: Напишите программу вычисления функции Аккермана.


int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAсkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAсkerman} ");

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}





