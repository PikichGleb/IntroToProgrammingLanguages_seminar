// C клавиатуры вводится строка - перевернуть её.
/* 
string s =Console.ReadLine();
for(int i =s.Length-1; i>=0;i--)
    Console.Write(s[i]);
//Console.WriteLine(new string(s.Reverse().ToArray()));
 */

//Даны две строки. Можно ли из символов одной строчки, составить другую сточку

/* 
string s1 =Console.ReadLine();
string s2 =Console.ReadLine();

char[] c1 = s1.ToArray();
Array.Sort(c1);
string ss1 = new String(c1);

char[] c2 = s2.ToArray();
Array.Sort(c2);
string ss2 = new String(c2);

// Console.WriteLine(ss1);
// Console.WriteLine(ss2);

if(ss1==ss2) Console.WriteLine("Yes"); 
else Console.WriteLine("No"); 
*/

// Вводится строка. Преобразовать все латинские большие слова в маленикие
/* 
string s = Console.ReadLine();
Console.WriteLine(s.ToLower());
*/

// Вывести на экран кодировку символов по ASCII(с 32 до 122)
/* 
string s;
for (int i = 32; i <= 122; i++)
{
    Console.WriteLine((char)i);
} */

/*2. Вывести на экран символы от A до Z как показано ниже: 
A 
BB 
CCC*/
/* 
for(int i =65; i<=90; i++)
{
    for(int j = 0; j < i-64; j++)

        Console.Write((char)i);
    Console.WriteLine();
}
*/


/* 
//Подсчитать сумму цифр среди вводимых с клавиатуры символов

string s = Console.ReadLine();
int sum = 0;
for (int i = 0; i < s.Length; i++)
    //if(s[i]>='0' && s[i]<='9')
    if(char.IsDigit(s[i]))
        sum+=(int)(char.GetNumericValue(s[i]));
Console.WriteLine(sum); */


//Подсчитать количество цифр среди вводимых с клавиатуры символов

string s = Console.ReadLine();
int sum = 0;
for (int i = 0; i < s.Length; i++)
    //if(s[i]>='0' && s[i]<='9')
    if(char.IsDigit(s[i]))
        sum+=1;//(int)(char.GetNumericValue(s[i]));
Console.WriteLine(sum);