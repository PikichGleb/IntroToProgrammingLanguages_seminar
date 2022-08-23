/* 
char c = 'a'; // UTF-16 - 2^16 = 65536

ConsoleKeyInfo ck;
do
{
    ck = Console.ReadKey();
    Console.WriteLine(ck.KeyChar);
    Console.WriteLine("IsDigit" + char.IsDigit(ck.KeyChar));
    Console.WriteLine("IsControl" + char.IsControl(ck.KeyChar));
    Console.WriteLine("IsLetter" + char.IsLetter(ck.KeyChar));
}
while (ck.Key != ConsoleKey.Escape);

Console.WriteLine('a'.ToString() + 'b');
if (c >= 'A' && c <= 'Z') Console.WriteLine("Latin");
if (c >= 'a' && c <= 'z') Console.WriteLine("Latin"); 
*/

/* 
string str = "HelLo"; // System.String str1;
Console.WriteLine(str[0].ToString() + str[1]);
for (int i = 0; i < str.Length; i++)
    if (str[i] >= 'A' && str[i] <= 'Z')
        Console.WriteLine(str[i]);

// immutable - неизменяемые 

char [] c = str.ToArray();
c[0] = 'h';
str=new string(c);
*/

/* 
string str = "Hello";
str = str.Remove(0, 1);
Console.WriteLine(str);
*/

string s;
s="2222";

s.Concat("123"); // s=s+"123";
s="1111";

s=s.Replace('1','2');

s.Contains('1');

s=s.Insert(1,"0");

Console.WriteLine(s);
Console.WriteLine(s.IndexOf("0"));

string s1 ="123";
if(s1==s);
if(s.CompareTo(s1)<0);
if(String.Compare(s,s1)>0);

