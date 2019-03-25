using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Chore : IChore
    {
        ILogger _logger = null;

        IMessageSender _messageSender = null;

        public Chore(ILogger logger, IMessageSender messageSender)
        {
            _logger = logger;
            _messageSender = messageSender;
        }

        public string Chorename { get; set; }

        public IPerson Owner { get; set; }

        public int HoursWorked { get; set; }

        public bool IsComplete { get; set; }


        public void PerfomedWord(int hours)
        {
            HoursWorked += hours;
            _logger.Log($"Completed Performed Work with {hours}");
        }

        public void CompleteChore()
        {
            IsComplete = true;
            _logger.Log($"Completed Chore");
            _messageSender.SendMessage("Sending Message as Completed Chore");
        }
            
    }
}
