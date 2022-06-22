using System;

namespace UserWork
{
    class User
    {
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 18)
                    Console.WriteLine("Возраст должен быть не меньше 18");
                else
                    age = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            //Setter
            user.Age = 23;

            //Getter
            Console.WriteLine(user.Age);

            Console.ReadLine();
        }
    }
}
