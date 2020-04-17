using Singleton_Object_Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Object_Example.Models.Writers.Abstract
{
    public abstract class WriterAbstract : IWriter
    {
        public string Msg { get; set; }

        public  void Compile()
        {
            Msg = DateTime.Now.ToString()+ "|" + Msg;
        }

        public void Write()
        {
            Services.FileWriter.Instance.WriteLine(Msg);
        }
    }
}
