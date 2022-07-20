namespace InterfacePractices
{
    public interface IMessanger<T>              //Обощённый интерфейс
    {
        T DeviceInfo();
    }

    public class Viber : IMessanger<Phone>
    {
        public Phone DeviceInfo()
        {
            throw new NotImplementedException();
        }
    }

    public class Phone { }
    public class Computer { }
}