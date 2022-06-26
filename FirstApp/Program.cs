abstract class FourLeggedAnimal
{
    public abstract void Describe();
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
    public override void Describe()
    {
        Console.WriteLine("Это животное - кошка");
    }
}