using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Manager : Employee, IManaged
    {
        public override int CalculateSalaryPerHour()
        {
            Salary = 20;
            return Salary;
        }
        public void AssignManager(string managername)
        {
            Manager = managername;
        }

        public void GiveEmployeeReviews(Employee emp)
        {
            Console.WriteLine($"Manager Review given for =>{emp.Firstname}, {emp.Lastname} ");
        }
    }
}
