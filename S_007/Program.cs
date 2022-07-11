// 7. Выяснить является ли число чётным.

Console.Write("Введите третие число :");
string? c1 = Console.ReadLine();
int c2 = Convert.ToInt32(c1);
int c3 = 2;
int c4 = (c2 % c3);

if(c4 == 0)
{
    Console.Write("Четное число");
}
else{
    Console.Write("Не чётное число");
}


//P.S. Воооооот где я поломал голову из-за того, что незнал как в if запихнуть "переменная / 2"...