﻿using OCP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Interfaces
{
    public interface IAccounts
    {
        EmployeeModel Create(IApplicantModel person);
    }
}
