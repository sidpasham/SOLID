using OCP.Accounts;
using OCP.Interfaces;
using OCP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IApplicantModel> applicants = new List<IApplicantModel>()
            {
                new PersonModel(){Firstname = "Sid", Lastname = "Pasham"},
                new ManagerModel(){Firstname ="Walter", Lastname="Mehra"},
                new ExecutiveModel(){Firstname="Rob", Lastname="Hardie"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var applicant in applicants)
            {
                employees.Add(applicant.AccountsProcessor.Create(applicant));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"FirstName:{emp.Firstname}|Lastname:{emp.Lastname}|Manager:{emp.IsManager}|Executive:{emp.IsExecutive}");
            }

            Console.ReadLine();
        }
    }
}
