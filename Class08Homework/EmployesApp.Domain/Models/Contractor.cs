using EmployesApp.Domain.Enums;

namespace EmployesApp.Domain.Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor(string firstName, string lastName, Role role, double salary, double workHours, int payPerHour, Manager responsible) : base(firstName, lastName, role, salary)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }

        public override double GetSalary()
        {
            double salary = WorkHours * PayPerHour;
            Salary = salary;
            return salary;
        }



    }
}
