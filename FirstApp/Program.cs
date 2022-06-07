using System;

class FirstApp
{
    static void Main(string[] args)
    {
        (string name, string birthdate, int age) anketa;
        
        Console.Write("Enter your name: ");
        anketa.name = Console.ReadLine();

        Console.Write("Enter your age: ");
        anketa.age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Your name is {anketa.name} and age is {anketa.age}");

        Console.Write("Enter your birthdate: ");
        anketa.birthdate = Console.ReadLine();
        Console.WriteLine($"Your birthdate is {anketa.birthdate}");

        Console.ReadKey();
	}
}