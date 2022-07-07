[Serializable] //   Атрибут сериализации
class Person
{
    //     Простая модель класса 
    [NonSerialized]
    private string name;
    public string Name { get { return name; } set { name = value; } }
    public int Year { get; set; }

    // Метод - конструктор
    public Person(string name, int year)
    {
        Name = name;
        Year = year;
    }
}