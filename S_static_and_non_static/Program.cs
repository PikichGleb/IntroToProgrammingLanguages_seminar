class Program
{
    static void Main() //Точка входа в программу
    {
        int[] a;
        MyLibrary.Init(out a, 20);

        MyClass myClass = new MyClass();
        MyClass myClass2 = new MyClass();
        MyClass myClass3 = new MyClass();
        myClass.Init(10);

        Person.Count = 0;
        Person elf = new Person();
        elf.Create(100, 50, 1);
        Person dwarf = new Person();
        dwaarf.Create(100, 80, 2);
        elf.Run();
        dwarf.Die();
    }
}

class Person
{
    //дынные
    int health;
    int power;
    int status;
    public static int Count = 0;

    public void Create(int health, int power, int status)
    {

    }
    public void Run()
    {
        Random random=new Random();
        random.Next(1,10);
    }
    public void Die()
    {

    }
}

class MyClass
{
    int[] a;
    public void Init(out int[] a, int Length)
    {
        a = new int[Length];
        for (int i; i < Length; i++) a[i] = i;
    }
}

class MyLibrary
{
    static public void Init(out int[] a, int Length)
    {
        a = new int[Length];
        for (int i; i < Length; i++) a[i] = i;
    }
}

class Math
{
    static double Abs(double a)
    {
        return 1;
    }
}