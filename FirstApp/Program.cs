class Program
{
    delegate int SubDelegate(int a, int b);
    static void Main()
    {
        SubDelegate sub = Sub;

        Console.WriteLine(sub.Invoke(5, 2));

        Console.WriteLine(sub(7, 2));
    }

    static int Sub(int a, int b)
    {
        return a - b;
    }
}