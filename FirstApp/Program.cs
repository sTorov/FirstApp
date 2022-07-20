public interface IWorker
{
    public void Build();
}

class BaseWorker : IWorker
{
    void IWorker.Build()
    {
        
    }
}

class Program
{
    static void Main()
    {
        BaseWorker worker = new BaseWorker();

        ((IWorker)worker).Build();
        
        Console.ReadLine();
    }
}