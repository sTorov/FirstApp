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
            throw new ArgumentOutOfRangeException("Ошибка");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.Read();
        }

        Console.ReadLine();
    }
}