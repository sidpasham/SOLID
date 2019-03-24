using OCP.Accounts;
using OCP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Models
{
    public class PersonModel : IApplicantModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public IAccounts AccountsProcessor { get; set; } = new PersonAccounts();

    }
}
