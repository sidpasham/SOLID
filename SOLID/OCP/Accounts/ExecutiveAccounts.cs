using OCP.Interfaces;
using OCP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Accounts
{
    public class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.Firstname = person.Firstname;
            output.Lastname = person.Lastname;
            output.IsManager = true;
            output.IsExecutive = true;

            return output;
        }
    }
}
