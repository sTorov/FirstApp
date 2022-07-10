class Program
{
    delegate void ShowMessageDelegate();
    delegate int SumDelegate(int a, int b, int c);
    delegate bool CheckLengthDelegate(string _row);
    static void Main()
    {
        ShowMessageDelegate showMessageDelegate = ShowMessage;
        showMessageDelegate.Invoke();

        SumDelegate sumDelegate = Sum;
        Console.WriteLine(sumDelegate.Invoke(1, 2, 3));

        CheckLengthDelegate checkLengthDelegate = CheckLength;
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