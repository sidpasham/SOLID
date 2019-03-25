using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Emailer : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending Email as =>{message}");
        }
    }
}
