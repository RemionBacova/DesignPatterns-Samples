using Singleton_Object_Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Object_Example.Models.Writers.Abstract
{
    class WriterAbstract : IWriter
    {
        public void Write(string Msg)
        {
            Services.FileWriter.Instance.WriteLine(Msg);
        }
    }
}
