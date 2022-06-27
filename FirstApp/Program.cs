abstract class FourLeggedAnimal
{
    public abstract string Name { get; set; }
}
class Dog : FourLeggedAnimal
{
    private string name;
    public override string Name 
    {
        get
        {
            return name;
        } 
        set
        {
            name = value;
        }
    }
}
class Cat : FourLeggedAnimal
{
    public override string Name { get; set; }
}