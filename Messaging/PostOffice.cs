using System;
using System.Collections.Generic;
using System.Text;

namespace Messaging.Server
{
    public class PostOffice
    {
        private string currentMessage;

        public void ReadOutbox(PersonA person)
        {
            currentMessage = person.GetOutboxMessage();
        }
            
        public void DeliverMessage(PersonB person)
        {
            person.SetOutboxMessage(currentMessage);
        }
    }
}
