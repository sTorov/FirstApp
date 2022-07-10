namespace DelegateDemo
{
    public class AnonymousMethods
    {
        public delegate string GreetingsDelegate(string name);

        static void Main(string[] args)
        {
            string Message = "добро пожаловать на SkillFactory!";       //+++
            GreetingsDelegate gd = delegate (string name)
            {
                return "Привет @" + name + " " + Message;               //+++
            };
            string GreetingsMessage = gd.Invoke("Будущий гуру");
            Console.WriteLine(GreetingsMessage);
            Console.ReadKey();
        }
    }
}