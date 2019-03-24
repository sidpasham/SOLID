using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Models
{
    public class EmployeeModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public bool IsManager { get; set; }
        public bool IsExecutive  { get; set; }
    }
}
