class Parent { }
class Child : Parent { }
class Program
{
    delegate void ChildInfo(Child child);
    static void Main()
    {
        ChildInfo childInfo = ParentInfo;
        childInfo.Invoke(new Child());
    }
    static void ParentInfo(Parent parent)
    {
        Console.WriteLine(parent.GetType());
    }
}