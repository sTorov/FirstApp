namespace InterfacePractices
{
    class Program
    {
        static void Main()
        {
            IMessanger<Phone> viberInPhone = new Viber<Phone>();                //Обычное обобщение
            IMessanger<IPhone> viberInIPhone = new Viber<IPhone>();             //Обычное обобщение

            IMessanger<Phone> viberOutPhone = new Viber<IPhone>();              //Ковариация (более конкретный тип, нежели указан в обобщении)

            viberInPhone.DeviceInfo();
            viberInIPhone.DeviceInfo();

            Console.ReadLine();
        }
    }
    
    public interface IMessanger<out T>              //Ковариантный интерфейс !!!<out T>
    {
        T DeviceInfo();
    }

    public class Viber<TPhone> : IMessanger<TPhone> where TPhone : Phone, new()
    {
        public TPhone DeviceInfo()
        {
            TPhone device = new TPhone();
            Console.WriteLine(device);
            return new TPhone();
        }
    }

    public class Phone { }
    public class IPhone : Phone { }
    public class Computer { }
}