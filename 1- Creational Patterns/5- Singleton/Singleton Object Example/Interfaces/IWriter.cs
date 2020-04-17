using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Object_Example.Interfaces
{
    public interface IWriter
    {
        public String Msg { get; set; }
        public void Write();

        public void Compile();
    }


}
