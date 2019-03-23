using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class PersonDataCapture
    {

        public static Person Capture()
        {
            Person output = new Person();

            Console.WriteLine("Please Enter the First Name");
            output.Firstname = Console.ReadLine();

            Console.WriteLine("Please Enter the Last Name");
            output.Lastname = Console.ReadLine();

            return output;
        }
    }
}
