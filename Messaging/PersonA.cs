using System;
using System.Collections.Generic;
using System.Text;

namespace Messaging.Server
{
    public class PersonA
    {
        private string outboxMessage;

        public string CreateNewMessage()
        {
            return "This is a new message created at " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

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
