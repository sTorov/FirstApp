using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    [Serializable]
    class Contact
    {
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string name, long phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var contact = new Contact("Dima", 89991112233, "Dima@gmail.com");

            BinaryFormatter formatter = new BinaryFormatter();

            using (var fs = new FileStream(@"C:\Users\1357680\Desktop\Contact.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, contact);
                Console.WriteLine("Файл сериализован");
            }

            Console.ReadLine();
        }
    }
}
