using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class AccountGenerator
    {
        public static void GeneratorAccount(Person person)
        {
            Console.WriteLine($"Your Username is {person.Firstname[0]}{person.Lastname}");
        }
    }
}
