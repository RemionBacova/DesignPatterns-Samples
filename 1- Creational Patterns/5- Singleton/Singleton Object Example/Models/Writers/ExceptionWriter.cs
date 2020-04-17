using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Object_Example.Models.Writers
{
    class ExceptionWriter : Abstract.WriterAbstract
    {
        public void GetMsg(Exception ex)
        {
            this.Msg = "|Exception|" + ex.Message + "|" + ex.InnerException;
        }
    }
}
