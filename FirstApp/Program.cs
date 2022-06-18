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

    //Конструктор. Для структуры обязательно должны быть объявлены все поля
    public Animal(string t, string n, int a)
    {
        type = t;
        name = n;
        age = a;
    }
}

class General
{
    static void Main(string[] args)
    {
        //Human person = new();
        //person.Greetings();

        ////Инициализатор
        //person = new Human{name = "Dima", age = 26};
        //person.Greetings();

        Animal animal = new("cat", "Barsik", 4);
        animal.Info();

        //Инициализатор. Для структур не обязательно в инициализаторе указывать все поля
        animal = new Animal {type = "Dog", name = "Tuzik", age = 6};
        animal.Info();

        Console.ReadLine();
    }
}