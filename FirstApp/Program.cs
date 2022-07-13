public delegate void Notify();  // делегат                
public class ProcessBusinessLogic
{
    public event Notify ProcessCompleted; // событие
    public void StartProcess()
    {
        Console.WriteLine("Процесс начат!");
        OnProcessCompleted();
    }
    protected virtual void OnProcessCompleted()
    {
        ProcessCompleted?.Invoke();
    }
}

class Program
{
    static void Main()
    {
        ProcessBusinessLogic bl = new ProcessBusinessLogic();
        bl.ProcessCompleted += bl_ProcessCompleted;
        bl.StartProcess();
    }
    //Перехватчик событий
    public static void bl_ProcessCompleted()
    {
        Console.WriteLine("Процесс завершен!");
    }
}