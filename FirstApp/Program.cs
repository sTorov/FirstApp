class Program
{
    static void Main()
    {
        Exception exception = new Exception();

        exception.Data.Add("Дата создания исключения: ", DateTime.Now);
    }
}