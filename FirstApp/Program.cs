using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    // Описываем наш класс и помечаем его атрибутом для последующей сериализации
    [Serializable]
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Pet(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // объект для сериализации
            var pet = new Pet("Rex", 2);
            Console.WriteLine("Объект был создан");

            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (var fs = new FileStream("myPets.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, pet);
                Console.WriteLine("Файл сериализован");
            }
            // десериализация
            using (var fs = new FileStream("myPets.dat", FileMode.OpenOrCreate))
            {
                var newPet = (Pet)formatter.Deserialize(fs);
                Console.WriteLine("Файл десериализован");
                Console.WriteLine($"Имя: {newPet.Name} -- Возраст: {newPet.Age}");
            }
            Console.ReadLine();
        }
    }
}
