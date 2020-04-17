using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Object_Example.Models.Writers
{
    class ErrorWriter : Writers.Abstract.WriterAbstract
    {
        public void GetMsg (string Error, string From)
        {
            this.Msg = "|Error|" + Error + "|" + From;
        }

    }
}
