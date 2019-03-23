using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {

            StandardMessages.WelcomeMessage();

            var user = PersonDataCapture.Capture();

            bool isUserDataValid = Validator.ValidatePerson(user);

            if(isUserDataValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            AccountGenerator.GeneratorAccount(user);

            StandardMessages.EndApplication();
        }
    }
}
