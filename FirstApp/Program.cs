abstract class Person
{
    public string Name;
    
    public Person(string name)
    {
        Name = name;
    }
    public void DisplayName()
    {
        Console.WriteLine(Name);
    }
}
class Employee : Person
{
    //Булевый флаг, сообщающий, находится ли сотрудник на смене
    private bool IsOnShift;

    public Employee(bool isOnShift, string name) : base(name)
    {
        IsOnShift = isOnShift;
    }
}
class Guest : Person
{
    //Дата и время прибытия гостя
    private DateTime ArrivalDate;

    public Guest (DateTime arrivalDate, string name) : base (name)
    {
        ArrivalDate = arrivalDate;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee (true, "Николай" );
        Guest guest = new Guest (new DateTime(2022, 3, 10), "Андрей");

        //Также мы можем создавать объекты данных типов и обращаться к ним как объектам типа Person:
        Person person = employee;
        person = guest;
    }
}