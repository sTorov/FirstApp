namespace FirstApp
{
    public class Contact // модель класса
    {
        public Contact(long phoneNumber, string email) // метод-конструктор
        {
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public long PhoneNumber { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return "Телефон: " + PhoneNumber + " E-mail: " + Email;
        }
    }
}
