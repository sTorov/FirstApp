class Animal { }

class Dog : Animal { }

class Program
{
    public delegate Animal HandlerMethod();
    public delegate void DogInfo(Dog dog);
    static void Main()
    {
        DogInfo dogInfo = GetAnimalInfo;
        dogInfo.Invoke(new Dog());                      //котравариация

        HandlerMethod handlerMethod = HandlerAnimal;    //обычное присвоение
        HandlerMethod handlerDog = HandlerDog;          //ковариация

        Console.ReadLine();
    }
    public static void GetAnimalInfo(Animal p)
    {
        Console.WriteLine(p.GetType());
    }


    public static Animal HandlerAnimal() 
    {
        return null;
    }
    public static Dog HandlerDog()
    {
        return null;
    }
}