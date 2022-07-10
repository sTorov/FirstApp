class Program
{
    static void Main() 
    {
        Action showMessageDelegate = ShowMessage;
        showMessageDelegate.Invoke();

        Func<int, int, int, int> sumDelegate = Sum;
        Console.WriteLine(sumDelegate.Invoke(1, 2, 3));

        Predicate<string> checkLengthDelegate = CheckLength;
        Console.WriteLine(checkLengthDelegate.Invoke("skill_factory"));
    }

    static void ShowMessage()
    {
        Console.WriteLine("Hello World!");
    }

    static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }

    static bool CheckLength(string _row)
    {
        if (_row.Length > 3) return true;
        return false;
    }
}