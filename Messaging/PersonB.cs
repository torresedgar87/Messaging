using System;
using System.Collections.Generic;
using System.Text;

namespace Messaging.Server
{
    public class PersonB
    {
        private string outboxMessage;

        public void SetOutboxMessage(string message)
        {
            outboxMessage = message;
        }

        public string GetOutboxMessage()
        {
            return outboxMessage;
        }
    }
}
