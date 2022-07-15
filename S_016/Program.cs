// 16. Дано число. Проверить кратно ли оно 7 и 23

//int a = 7*23;
                                                                                    //int a = Convert.ToInt32(Console.ReadLine());
bool b = a % 7 == 0 && a % 23 == 0;
//Console.WriteLine(b);
if(b)
{
    Console.WriteLine("Кратно");
}
else{
    Console.WriteLine("Не Кратно");
}