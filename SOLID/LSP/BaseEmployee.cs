using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public abstract class BaseEmployee : IBaseEmployee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Salary { get; set; }

        public virtual int CalculateSalaryPerHour()
        {
            Salary = 10;

            return Salary;
        }
    }
}
