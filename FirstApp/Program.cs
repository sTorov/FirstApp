public interface IWorker
{
    void Build();
}

class BaseWorker : IWorker
{
    public void Build()
    {
        
    }
}

class Program
{
    static void Main()
    {
        BaseWorker worker = new BaseWorker();

        worker.Build();
        
        Console.ReadLine();
    }
}