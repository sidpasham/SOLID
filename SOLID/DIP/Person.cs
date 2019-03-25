using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Person : IPerson
    {
        public string Firstname { get; set; }
        public string  Lastname { get; set; }
        public int Age { get; set; }
        public string  Email { get; set; }

    }
}
