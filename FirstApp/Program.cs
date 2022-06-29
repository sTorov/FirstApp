//Реализация наследования без указания типа. Важно понимать, что с таким способом наследования класс-наследник
//может быть только обобщённым. Но это повышает гибкость.
class BaseClass<T>
{
    public T Field;
}
class DerivedClass<T> : BaseClass<T>
{
    public T Property { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        DerivedClass<int> derived = new DerivedClass<int>();
        derived.Field = 13;     // Тип int
        derived.Property = 22;	// Тип int
    }
}