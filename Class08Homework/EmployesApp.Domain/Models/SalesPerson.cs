using EmployesApp.Domain.Enums;

namespace EmployesApp.Domain.Models
{
    public class SalesPerson : Employee
    {
        private double _successSaleRevenue { get; set; }

        public SalesPerson(string firstName, string lastName, double successSaleRevenue) : base(firstName, lastName, Role.Sales, 500)
        {
            _successSaleRevenue = 0;
        }

        public void AddSuccessRevenue(double amout)
        {
            _successSaleRevenue += amout;
        }

        public override double GetSalary()
        {
            if(_successSaleRevenue <= 2000)
            {
                return Salary + 500;
            }
            else if(_successSaleRevenue > 2000 && _successSaleRevenue <= 5000)
            {
                return Salary + 1000;
            }
            else
            {
                return Salary + 1500;
            }
        }
    }
}
