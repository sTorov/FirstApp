public interface IWhatsApp                      //Интерфейс 1
{
    public void SendMessage(string message); 
}

public interface IViber                         //Интерфейс 2
{
    public void SendMessage(string message);
}

public class NewMessage : IWhatsApp, IViber     //Реализация 2-х интерфейсов, имеющих одинаковую сигнатуру
{
    void IWhatsApp.SendMessage(string message)              //Явная реализация интерфейса
    {
        Console.WriteLine("{0}: {1}", "WhatsApp", message);
    }

    void IViber.SendMessage(string message)                 //Явная реализация интерфейса
    {
        Console.WriteLine("{0}: {1}", "Viber", message);
    }
}

class Program
{
    static void Main()
    {
        NewMessage newMessage = new NewMessage();

        ((IWhatsApp)newMessage).SendMessage("Hello world");             //Вызов метода интерфейса IWhatsApp  
        ((IViber)newMessage).SendMessage("Hello world");                //Вызов метода интерфейса IViber

        Console.ReadLine();
    }
}