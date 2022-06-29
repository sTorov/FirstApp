//В данном случае классу-наследнику необязательно быть обобщением, это может быть и обычный класс.
//Его использование будет выглядеть как:
class BaseClass<T>
{
    public T Field;
}
class DerivedClass : BaseClass<int>
{
    public string Property { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        DerivedClass derived = new DerivedClass();
        derived.Field = 13;         // Тип int
        derived.Property = "22";	// Тип string
    }
}