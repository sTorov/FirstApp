using System;

class BaseClass
{
    protected string Name;

    public BaseClass(string name)
    {
        Name = name;
    }
}

class DerivedClass : BaseClass
{
    public string Description;
    public int Counter;

    public DerivedClass(string name, string discription) : base(name)
    {
        Description = discription;
    }
    public DerivedClass(string name, string description, int counter) : this(name, description)
    {
        Counter = counter;
    }
}
class Program
{
    static void Main(string[] args)
    {
        BaseClass derived = new DerivedClass("Без имени", "Описание", 12);
        Console.ReadKey();
    }
}