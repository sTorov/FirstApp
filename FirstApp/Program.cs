class Program
{
    static void Main()
    {
        try
        {
            throw new RankException();
        }
        catch (RankException ex)
        {
            Console.WriteLine(ex.GetType());
        }
        finally
        {
            Console.Read();
        }

        Console.ReadLine();
    }
}