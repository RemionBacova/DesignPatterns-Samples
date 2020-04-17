using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Object_Example.Models.Writers
{
    class MessageWriter : Abstract.WriterAbstract
    {
        public void GetMsg(string msg, string from)
        {
            this.Msg = "|Message|" + msg + "|" + from;
        }
    }
}
