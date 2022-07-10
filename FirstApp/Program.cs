class Program
{
    delegate void ShowDelegate();
    static void Main()
    {
        ShowDelegate show = Method1;
        show += Method2;
        show += Method3;
        show += Method4;

        show -= Method4;
        show -= Method2;

        show.Invoke();
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