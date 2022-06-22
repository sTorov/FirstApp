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

        private string login;
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                if (value.Length < 3)
                    Console.WriteLine("Логин должен содержать не менее 3-х символов");
                else
                    login = value;
            }           
        }
        
        private string email;
        public string Email
        {
            get 
            { 
                return email;
            }
            set
            {
                if (!value.Contains('@'))
                    Console.WriteLine("Email должен содержать символ '@'");
                else
                    email = value;
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
            user.Login = "Dima";
            user.Email = "Dima@gmail.com";

            //Getter
            Console.WriteLine(user.Age);
            Console.WriteLine(user.Login);
            Console.WriteLine(user.Email);

            Console.ReadLine();
        }
    }
}
