using static DelegatePractices.Program;

namespace DelegatePractices
{
    public class Program
    {
        public delegate bool PowerUpEmployee(Employee employee);
        static void Main(string[] args)
        {
            Employee employee1 = new Employee()
            {
                Id = 44,
                Name = "Dima",
                Salary = 25000,
                Expirience = 5,
            };
            Employee employee2 = new Employee()
            {
                Id = 45,
                Name = "Ivan",
                Salary = 10000,
                Expirience = 2,
            };

            PowerUpEmployee powerUpEmployee = PowerUp;

            List<Employee> listEmployees = new List<Employee>();
            listEmployees.Add(employee1);
            listEmployees.Add(employee2);

            Employee.PromoEmploy(listEmployees, powerUpEmployee);
        }

        static bool PowerUp(Employee employee)
        {
            if (employee.Salary > 10000)
                return true;
            else
                return false;
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Expirience { get; set; }

        public static void PromoEmploy(List<Employee> employees, PowerUpEmployee powerUpEmployee)
        {
            foreach (var employee in employees)
            {
                if(powerUpEmployee.Invoke(employee))
                    Console.WriteLine($"Сотрудник {employee.Name} повышен");
            }
        }
    }
}