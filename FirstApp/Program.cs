namespace InterfacePractices
{
    class Program
    {
        static void Main()
        {
            User user = new User();
            Account account = new Account();
            
            IUpdater<Account> updater = new UserService(); 

            var userService = new UserService();
            userService.Update(user);
        }
    }

    public class User
    {

    }

    public class Account : User
    {

    }

    public interface IUpdater<in T>
    {
        void Update(T entity);
    }

    class UserService : IUpdater<User>
    {
        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}