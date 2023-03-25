using EmployesApp.Domain.Enums;

namespace EmployesApp.Domain.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }

        protected double Salary { get; set; }

        public Employee(string firstName, string lastName, Role role, double salary)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                Console.WriteLine("First name cannot be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                Console.WriteLine("Last name cannot be null or empty.");
            }

            if (salary < 0)
            {
                Console.WriteLine("Salary can`t be negative.");
            }

            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;

        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} gets salary: {Salary}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
