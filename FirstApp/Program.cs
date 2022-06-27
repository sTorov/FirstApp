class SimpleClass
{
    public static int MinValue = 100;

    public int Value;

    public SimpleClass(int value)
    {
        if (value < MinValue)
        {
            Value = MinValue;
        }
        else
        {
            Value = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SimpleClass simpleClass = new(200);
        SimpleClass simpleClass2 = new(30);

        /*
         * Для обращения к статическому элементу вне класса, стоит обращаться к нему через класс, 
         * в котором он располагается, в нашем случае — SimpleClass.
         */

        Console.WriteLine(SimpleClass.MinValue);

        Console.ReadKey();
    }
}