using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {

            IPerson person = Factory.CreatePerson();

            person.Firstname = "Sid";
            person.Lastname = "Pasham";
            person.Age = 26;
            person.Email = "sidpasham@gmail.com";

            IChore chore = Factory.CreateChore();
            chore.PerfomedWord(5);
            chore.PerfomedWord(7);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
