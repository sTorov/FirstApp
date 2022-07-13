public delegate void Notify();  // делегат                
public class ProcessBusinessLogic
{
    public event Notify ProcessCompleted; // событие
}