class Program
{
    public interface ILogger        //Объявление интерфейса
    {
        void Log()
        {
            Console.WriteLine("Hello! I am Logger!");
        }
    }

    public interface IWriter        //Объявление интерфейса
    {
        void Write()
        {
            Console.WriteLine("Hello! I am Writer!");
        }
    }

    public class Writer : IWriter , ILogger      //Множественное наследование интерфейсов
    {                                   

    }
}