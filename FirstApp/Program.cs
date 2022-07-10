class Program
{
    delegate void ShowDelegate();
    static void Main()
    {
        ShowDelegate show1 = Method1;
        show1 += Method3;

        ShowDelegate show2 = Method2;
        show2 += Method4;

        ShowDelegate show3 = show1 + show2;

        show3.Invoke();
    }

    static void Method1()
    {
        Console.WriteLine("Метод 1");
    }
    static void Method2()
    {
        Console.WriteLine("Метод 2");
    }
    static void Method3()
    {
        Console.WriteLine("Метод 3");
    }
    static void Method4()
    {
        Console.WriteLine("Метод 4");
    }

}