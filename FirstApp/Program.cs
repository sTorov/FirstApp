class Program
{
    static int Division(int a, int b)
    {
        return a / b;
    }

    static void Main()
    {
        try
        {
            var result = Division(7, 0);

            Console.WriteLine(result);
        }
        catch (Exception ex)
        {
            if (ex is DivideByZeroException)
                Console.WriteLine("На ноль делить нельзя" + ex.Data);
            else
                Console.WriteLine("Произошла непредвиденная ошибка");
        }
        finally
        {
            Console.WriteLine("Сработал блок finally");
        }

        Console.ReadLine();
    }
}