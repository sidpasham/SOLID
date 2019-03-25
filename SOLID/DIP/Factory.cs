﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }

        public static IMessageSender CreateMessageSender()
        {
            return new Emailer();
        }
        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(),CreateMessageSender());
        }
    }
}
