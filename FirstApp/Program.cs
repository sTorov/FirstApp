using System;

class BaseClass
{
	public string Name;
	protected string Description;
	private int value;

    public BaseClass(int value, string Name)
    {
        this.value = value;
        this.Name = Name;
    }
}

class InheritedClass : BaseClass
{
	private int newValue;

    public InheritedClass(int newValue) : base(100, "null")
    {
        this.newValue = newValue;
    }
}
class Program
{
    static void Main(string[] args)
    {
        BaseClass @class = new InheritedClass(5);
        Console.ReadKey();
    }
}