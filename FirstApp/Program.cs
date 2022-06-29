//Также можно создавать класс-наследник как обобщение, у которого будет свой собственный тип:

class BaseClass<T>
{
    public T Field;
}
class DerivedClass<T> : BaseClass<int>
{
    public T Property { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        DerivedClass<string> derived = new DerivedClass<string>();
        derived.Field = 13;         // Тип int
        derived.Property = "22";	// Тип string

        DerivedClass<long> derived2 = new DerivedClass<long>();
        derived2.Field = 11;        // Тип int
        derived2.Property = 23;     // Тип long
    }
}