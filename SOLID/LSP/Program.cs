using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.Firstname = "Walter";
            manager.Lastname = "Mehra";
            manager.Salary = manager.CalculateSalaryPerHour();
            manager.AssignManager("Rob");

            Employee emp = new Employee();

            emp.Firstname = "Sid";
            emp.Lastname = "Pasham";
            emp.AssignManager(manager.Firstname);

            Console.WriteLine($"Employee => {emp.Firstname} manager => {emp.Manager}");
            Console.ReadLine();
        }
    }
}
