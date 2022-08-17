namespace FirstApp
{
    public class Contact // модель класса
    {
        public Contact(long phoneNumber, string email) // метод-конструктор
        {
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public long PhoneNumber { get; }
        public string Email { get; }

        public override string ToString()
        {
            return "Телефон: " + PhoneNumber + " E-mail: " + Email;
        }
    }
}
