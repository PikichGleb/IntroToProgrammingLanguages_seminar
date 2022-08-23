// C клавиатуры вводится строка - перевернуть её.
/* 
string s =Console.ReadLine();
for(int i =s.Length-1; i>=0;i--)
    Console.Write(s[i]);
//Console.WriteLine(new string(s.Reverse().ToArray()));
 */

//Даны две строки. Можно ли из символов одной строчки, составить другую сточку

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