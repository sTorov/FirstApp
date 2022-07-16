class Program
{
    public interface IWriter        //Объявление интерфейса
    {
        void Write();
    }

    public class Writer : IWriter       //Наследование интерфейса (контракт)
    {                                   //Класс-наследник обязан реализовать весь функционал интерфейса

    }
}