class Program
{
    public interface IWriter        //Объявление интерфейса
    {
        void Write()
        {
            Console.WriteLine("Hello! I am Writer!");
        }
    }

    public class Writer : IWriter       //Наследование интерфейса (контракт)
    {                                   

    }
}