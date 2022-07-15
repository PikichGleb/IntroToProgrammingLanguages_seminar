// 15. С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет. (c начала)

int a = Convert.ToInt32(Console.ReadLine());
//if(a>=100 || a<=-100)
if (Math.Abs(a) >= 100)
{
    Console.WriteLine(a / 100 % 10);
}
else
{
    Console.WriteLine("Число имеет меньшше трёх цифр");
}