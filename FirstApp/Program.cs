//При этом стоит учитывать, что если на уровне базового класса для универсального параметра установлено
//ограничение, то подобное ограничение должно быть определено и в производных классах, которые также используют
//этот параметр:

class BaseClass<T> where T : struct
{
    public T Field;
}
class DerivedClass<T> : BaseClass<T> where T : struct
{
    public T Property { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        DerivedClass<long> derived2 = new DerivedClass<long>();
        derived2.Field = 11;        // Тип long
        derived2.Property = 23;     // Тип long
    }
}