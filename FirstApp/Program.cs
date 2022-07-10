namespace DelegatePractices
{
    class Program
    {
        delegate int Calculate(int a, int c);
        delegate void Print();
        static void Main(string[] args)
        {
            Calculate calculation = (x, y) => x + y;
            Console.WriteLine(calculation(10, 20));
            Console.WriteLine(calculation(40, 20));
            Print print = () => Console.WriteLine("Hello world");
            print.Invoke();
            Console.Read();
        }
    }
}