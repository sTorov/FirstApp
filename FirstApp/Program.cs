using System;

class Human
{    
    //Поля класса
    public string name;
    public int age;

    //Метод класса
    public void Greetings()
    {
        Console.WriteLine($"Меня зовут {name}, мне {age}");
    }    

    //Конструктор
    public Human()
    {
        age = 99;
        name = "Неизвестно";
    }

    //Конструктор 2
    public Human(string n)
    {
        name = n;
        age = 99;
    }

    //Конструктор 3
    public Human(string n, int a)
    {
        age = a;
        name = n;
    }
}

struct Animal
{
    //Поля структуры
    public string type;
    public string name;
    public int age;

    //Метод структуры
    public void Info()
    {
        Console.WriteLine($"Это {type} по кличке {name}, ему {age}");
    }
}

class General
{
    static void Main(string[] args)
    {
        Human person = new();
        person.Greetings();

        person = new("Dima");
        person.Greetings();

        person = new("Dima", 26);
        person.Greetings();
        
        //Animal animal;
        //animal.age = 4;
        //animal.name = "Barsik";
        //animal.type = "cat";
        //animal.Info();
                
    }
}