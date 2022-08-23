//string5. Определить являются ли введенные с клавиатуры символы правильно записью целого числа. Вычислить сумму цифр введенного числа

Main();

static void Main()
{
    string num = Console.ReadLine();
    int temp = 0;
    if (!Int32.TryParse(num, out temp))
        Console.WriteLine("Это не является верной записью целого");
    else
    {
        int sum = 0;
        foreach (char digit in num)
            sum += digit - 48;
        Console.WriteLine(sum);
    }
}












// by tezaurismosis (Найдено в интернете)! //https://googleweblight.com/sp?hl=ru-RU&geid=NSTN&u=https://www.cyberforum.ru/csharp-beginners/thread1548957.html
