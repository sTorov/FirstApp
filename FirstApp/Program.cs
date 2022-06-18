using System;

class Human
{
    public class ClassHuman
    {
        public string Gender;

        public void GenderInfo()
        {
            Console.WriteLine(Gender);
        }
    }

    public struct StructHuman
    {
        public string Gender;

        public void GenderInfo()
        {
            Console.WriteLine(Gender);
        }
    }

    //Поля класса
    public string name;
    public int age;

    //Метод класса
    public void Greetings()
    {
        Console.WriteLine($"Меня зовут {name}, мне {age}");
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
        person.age = 43;
        person.name = "Dima";
        person.Greetings();

        Animal animal;
        animal.age = 4;
        animal.name = "Barsik";
        animal.type = "cat";
        animal.Info();

        Human.StructHuman newStruct;
        newStruct.Gender = "Man";
        newStruct.GenderInfo();

        Human.ClassHuman newClass = new();
        newClass.Gender = "Woman";
        newClass.GenderInfo();
    }
}