using Bridge_By_Example.Interfaces;
using System;

namespace Bridge_By_Example.Models.Messagges
{
    public class EmailMessage : IMessage
    {
        public void SendMessage(string to, string message)
        {
            Console.WriteLine("Email Message to :" + to + " with the content : " + message);
        }
    }
}
