namespace InterfacePractices
{
    class Program
    {
        static void Main()
        {
            IMessanger<Phone> viberInPhone = new Viber<Phone>();                //Обычное обобщение
            viberInPhone.DeviceInfo(new Phone());

            IMessanger<IPhone> viberInIPhone = new Viber<IPhone>();             //Обычное обобщение
            viberInIPhone.DeviceInfo(new IPhone());

            IMessanger<IPhone> viberOutPhone = new Viber<Phone>();              //Контравариация (более универсальный тип, нежели указан в обобщении)

            Console.ReadLine();
        }
    }
    
    public interface IMessanger<in T>              //Контрариантный интерфейс !!!<in T>
    {
        void DeviceInfo(T device);
    }

    public class Viber<TPhone> : IMessanger<TPhone> where TPhone : Phone
    {
        public void DeviceInfo(TPhone phone)
        {
            Console.WriteLine(phone);
        }
    }

    public class Phone { }
    public class IPhone : Phone { }
    public class Computer { }
}