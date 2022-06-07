using System;

class FirstApp
{
    static void Main(string[] args)
    {
        (string Name, string Type, double Age, int NameCount) Pet;

        Console.Write("Какой у Вас петомец?: ");
        Pet.Type = Console.ReadLine();

        Console.Write("Как зовут вашего петомца?: ");
        Pet.Name = Console.ReadLine();
        Pet.NameCount = Pet.Name.Length;

        Console.Write("Сколько ему лет?: ");
        Pet.Age = double.Parse(Console.ReadLine());

        Console.WriteLine("-------Анкета-------");
        Console.WriteLine($"Ваш петомец - {Pet.Type}");
        Console.WriteLine($"Вашего петомца зовут {Pet.Name}");
        Console.WriteLine($"Возраст вашего петомца {Pet.Age}");
        Console.WriteLine($"Длинна имени {Pet.Name}: " + Pet.NameCount);


        Console.ReadKey();
	}
}