abstract class FourLeggedAnimal
{
    public virtual void Describe()
    {
        Console.WriteLine("Неизвестное животное");
    }
}
class Dog : FourLeggedAnimal
{
    public override void Describe()
    {
        Console.WriteLine("Это животное - собака"); ;
    }
}
class Cat : FourLeggedAnimal
{
    
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        Cat cat = new Cat();

        dog.Describe();         // Собака
        cat.Describe();         // Неизвестное животное
        FourLeggedAnimal animal = dog;
        animal.Describe();      // Собака

        animal = cat;
        animal.Describe();      // Неизвестное животное
    }
}