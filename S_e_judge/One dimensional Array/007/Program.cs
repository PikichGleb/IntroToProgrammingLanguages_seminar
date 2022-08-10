//Даны N отрезков прямой. Найти длину общей части всех этих отрезков.

int n=int.Parse(Console.ReadLine());
int min=30001;
int max=-1;
int a=0,b=0;
for(int i=0;i<n;i++)
{
    string[] ss=Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
    a=int.Parse(ss[0]);
    b=int.Parse(ss[1]);
    //System.Console.WriteLine("a="+a);
    //System.Console.WriteLine("b="+b);
    if (a>max) max=a;
    if (b<min) min=b;
    //System.Console.WriteLine("max="+max);
    //System.Console.WriteLine("min="+min);

}
if (min-max<=0) System.Console.WriteLine(0);
    else
        System.Console.WriteLine(min-max);