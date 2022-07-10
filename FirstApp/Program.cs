namespace DelegatePractices
{
    class Program
    {
        delegate int CalculateDelegate(int a, int b);
        static void Main(string[] args)
        {
            CalculateDelegate calculateDelegate = delegate (int a, int b)
            {
                return a + b;
            };

            int result = calculateDelegate.Invoke(50, 10);
        }
    }
}