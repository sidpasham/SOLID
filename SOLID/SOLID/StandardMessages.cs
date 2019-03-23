using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the application");
        }

        public static void EndApplication()
        {
            Console.ReadLine();
        }

        public static void DisplayErrorMessage(string field)
        {
            Console.WriteLine($"{field} Cannot be null");
        }
    }
}
