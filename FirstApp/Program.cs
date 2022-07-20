public interface IWriter
{
    void Write();
}

class BaseWriter : IWriter
{
    void IWriter.Write()
    {
        
    }
}

class Program
{
    static void Main()
    {
        BaseWriter baseWriter = new BaseWriter();

        ((IWriter)baseWriter).Write();

        Console.ReadLine();
    }
}