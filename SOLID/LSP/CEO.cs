using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class CEO : BaseEmployee, IManager
    {
        public override int CalculateSalaryPerHour()
        {
            Salary = 30;
            return Salary;
        }
        public void GiveEmployeeReviews(Employee emp)
        {
            Console.WriteLine($"CEO Given reviews for {emp.Firstname}, {emp.Lastname}");
        }

        public void FireSomeone(Employee emp)
        {
            Console.WriteLine($"CEO Fired => {emp.Firstname}, {emp.Lastname}");
        }
    }
}
