using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Validator
    {

        public static bool ValidatePerson(Person person)
        {
            if (string.IsNullOrEmpty(person.Firstname))
            {
                StandardMessages.DisplayErrorMessage(person.Firstname);
                return false;

            }
            else if (string.IsNullOrEmpty(person.Lastname))
            {
                StandardMessages.DisplayErrorMessage(person.Lastname);
                return false;
            }

            return true;
        }
    }
}
