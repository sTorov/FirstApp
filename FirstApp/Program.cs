class Program
{
    delegate void ShowDelegate(int a, int b);
    static void Main()
    {
        ShowDelegate show = Sum;
        show += Sub;

        show.Invoke(1, 1); 
    }

    static void Sum(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    static void Sub(int a, int b)
    {
        Console.WriteLine(a - b);
    }
}