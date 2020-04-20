using Bridge_By_Example.Interfaces;
using Bridge_By_Example.Models.Messagges;
using Bridge_By_Example.Models.Messagges.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_By_Example.BridgeController
{
    public class MessageController
    {
        private IMessage Message { get; set; }

        public void SetMessageType(MessageType messageType)
        {
            switch (messageType)
            {
                case MessageType.Email:
                    Message = new EmailMessage();
                    break;
                case MessageType.SMS:
                    Message = new SMSMessage();
                    break;
            }
        }

        public void SendMessage(string to, string message)
        {
            Message.SendMessage(to, message);
        }
    }
}

