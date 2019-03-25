using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Employee: BaseEmployee
    {
        public string Manager { get; set; }

        public void AssignManager(string managername)
        {
            Manager = managername;
        }
    }
}
