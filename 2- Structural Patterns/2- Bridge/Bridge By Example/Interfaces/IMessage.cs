using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_By_Example.Interfaces
{
    public interface IMessage
    {
        void SendMessage(string to, string message);
    }
}
