using OCP.Interfaces;
using OCP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Accounts
{
    public class PersonAccounts : IAccounts
    {

        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.Firstname = person.Firstname;
            output.Lastname = person.Lastname;


            return output;
        }
    }
}
