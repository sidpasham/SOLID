using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Interfaces
{
    public interface IApplicantModel
    {
        string Firstname { get; set; }

        string Lastname { get; set; }

        IAccounts AccountsProcessor { get; set; }

    }
}
