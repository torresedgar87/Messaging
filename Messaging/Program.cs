using System;
using System.Collections.Generic;

namespace Messaging.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var postOffice = new PostOffice();
            var personA = new PersonA();
            var personB = new PersonB();

            //Create a new message and set in PersonA outbox
            var newMessage = personA.CreateNewMessage();
            Console.WriteLine("Message created: " + newMessage);
            personA.SetOutboxMessage(newMessage);

            //Post office get message from outbox and delivers to PersonB
            postOffice.ReadOutbox(personA);
            postOffice.DeliverMessage(personB);

            //PersonB reads message from outbox and displays it
            var deliveredMessage = personB.GetOutboxMessage();
            Console.WriteLine("Message delivered: " + deliveredMessage);

            //Only added this so the window won't close automatically 
            Console.ReadKey();
        }
    }
}
