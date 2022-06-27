class Helper
{
    public static void Swap(ref int num1,ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int num1 = 3;
        int num2 = 58;

        Helper.Swap(ref num1,ref num2);

        Console.WriteLine(num1); //58
        Console.WriteLine(num2); //3
    }
}