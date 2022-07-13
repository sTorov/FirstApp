class Car { }
class Lexus : Car { }
class Program
{
    public delegate Car CarInfo();
    static void Main()
    {
        CarInfo lexusInfo = LexusInfo;
        Lexus lexus = (Lexus)lexusInfo.Invoke();
    }
    static Lexus LexusInfo()
    { 
        return null;
    }
}