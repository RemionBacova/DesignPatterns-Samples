using Bridge_By_Example.Interfaces;
using System;

namespace Bridge_By_Example.Models.Messagges
{
    public class SMSMessage : IMessage
    {
        public void SendMessage(string to, string message)
        {
            Console.WriteLine("SMS Message to :" + to + " with the content : " + message);
        }
    }
}
